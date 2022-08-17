using MetroFramework;
using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BookRentalApp
{
    public partial class RentalForm : MetroFramework.Forms.MetroForm
    {
        string mode = "";

        public RentalForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'bookrentalshopDataSet.divtbl' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.divtblTableAdapter.Fill(this.bookrentalshopDataSet.divtbl);
            UpdateData();
            UpdateComboMember();
            UpdateComboBooks();

            DatRental.CustomFormat = " ";
            DatRental.Format = DateTimePickerFormat.Custom;

            DatReturn.CustomFormat = " ";
            DatReturn.Format = DateTimePickerFormat.Custom;
        }

        private void UpdateComboMember()
        {
            // 회원번호
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                conn.Open();
                string strQuery = "SELECT Idx, Names FROM membertbl ";
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboMember.DataSource = new BindingSource(temps, null);
                CboMember.DisplayMember = "Value";
                CboMember.ValueMember = "Key";
                CboMember.SelectedIndex = -1;
            }
        }

        private void UpdateComboBooks()
        {
            // 회원번호
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                conn.Open();
                // 두번째 책 관련 쿼리 만들기. 단 현재 빌려서 아직 반환을 안한 책은 제외 하기 위해 조인쿼리 사용
                string strQuery = "SELECT DISTINCT b.Idx, b.Names FROM bookstbl AS b " +
                                  "  LEFT OUTER JOIN rentaltbl AS r " +
                                  "    ON b.idx = r.bookIdx ";
                                  //" WHERE r.Idx IS NULL " +
                                  //"    OR (r.Idx IS NOT NULL AND r.rentalDate IS NOT NULL AND r.returnDate IS NOT NULL) ";
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboBooks.DataSource = new BindingSource(temps, null);
                CboBooks.DisplayMember = "Value";
                CboBooks.ValueMember = "Key";
                CboBooks.SelectedIndex = -1;
            }
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                conn.Open();
                string strQuery = "SELECT r.idx AS '대여번호', m.Names AS '대여회원', " +
                                  "       t.Names AS '장르', " +
                                  "       b.Names AS '대여책제목', b.ISBN, " +
                                  "       r.rentalDate AS '대여일', " +
                                  "       r.returnDate AS '반납일', " +
                                  "       m.Idx AS 'mIdx', " +
                                  "       b.Idx AS 'bIdx' " +
                                  "  FROM rentaltbl AS r " +
                                  " INNER JOIN membertbl AS m " +
                                  "    ON r.memberIdx = m.Idx " +
                                  " INNER JOIN bookstbl AS b " +
                                  "    ON r.bookIdx = b.Idx " +
                                  " INNER JOIN divtbl AS t " +
                                  "    ON b.division = t.division ";
                //MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "rentaltbl");

                GrdRentalTbl.DataSource = ds;
                GrdRentalTbl.DataMember = "rentaltbl";
            }

            SetColumnHeaders();
            mode = "";
        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column = GrdRentalTbl.Columns[7];
            column.Visible = false;
            column = GrdRentalTbl.Columns[8];
            column.Visible = false;

        }

        private void UpdateProcess()
        {
            //if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            //{
            //    MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (mode == "UPDATE")
                    {
                        cmd.CommandText = "UPDATE dbo.rentaltbl " +
                                          "   SET memberIdx = @memberIdx " +
                                          "     , bookIdx = @bookIdx " +
                                          "     , rentalDate = @rentalDate " +
                                          "     , returnDate = @returnDate " +
                                          " WHERE Idx = @Idx ";
                    }
                    else if (mode == "INSERT")
                    {
                        cmd.CommandText = " ";
                    }

                    MySqlParameter parmMemberIdx = new MySqlParameter("@memberIdx", MySqlDbType.Int32);
                    parmMemberIdx.Value = (CboMember.SelectedValue);
                    cmd.Parameters.Add(parmMemberIdx);
                    MySqlParameter parmBookIdx = new MySqlParameter("@bookIdx", MySqlDbType.Int32);
                    parmBookIdx.Value = (CboBooks.SelectedValue);
                    cmd.Parameters.Add(parmBookIdx);

                    MySqlParameter parmRentalDate = new MySqlParameter("@rentalDate", MySqlDbType.DateTime);
                    parmRentalDate.Value = DatRental.Value;
                    cmd.Parameters.Add(parmRentalDate);
                    MySqlParameter parmReturnDate = new MySqlParameter("@returnDate", MySqlDbType.DateTime);
                    parmReturnDate.Value = DatReturn.Value;
                    cmd.Parameters.Add(parmReturnDate);

                    MySqlParameter parmIdx = new MySqlParameter("@Idx", MySqlDbType.Int32);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "오류가 발생했습니다", "오류");
                }
                finally
                {
                    UpdateData();
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            mode = "INSERT";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdateProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatReturn.CustomFormat = " ";
            DatReturn.Format = DateTimePickerFormat.Custom;

            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdRentalTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                CboMember.SelectedIndex = CboMember.FindString(data.Cells[1].Value.ToString());
                CboBooks.SelectedIndex = CboBooks.FindString(data.Cells[3].Value.ToString());
                DatRental.CustomFormat = "yyyy-MM-dd";
                DatRental.Format = DateTimePickerFormat.Custom;
                DatRental.Value = DateTime.Parse(data.Cells[5].Value.ToString());

                if (!string.IsNullOrEmpty(data.Cells[6].Value.ToString()))
                {
                    DatReturn.CustomFormat = "yyyy-MM-dd";
                    DatReturn.Format = DateTimePickerFormat.Custom;
                    DatReturn.Value = DateTime.Parse(data.Cells[6].Value.ToString());
                }

                mode = "UPDATE";
            }
        }

        private void RentalForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatRental_ValueChanged(object sender, EventArgs e)
        {
            DatRental.CustomFormat = "yyyy-MM-dd";
            DatRental.Format = DateTimePickerFormat.Custom;
        }

        private void DatReturn_ValueChanged(object sender, EventArgs e)
        {
            DatReturn.CustomFormat = "yyyy-MM-dd";
            DatReturn.Format = DateTimePickerFormat.Custom;
        }

private void BtnExport_Click(object sender, EventArgs e)
{
    IWorkbook workbook = new XSSFWorkbook(); // HSSFWorkbook
    ISheet sheet1 = workbook.CreateSheet("Sheet1");
    sheet1.CreateRow(0).CreateCell(0).SetCellValue("This is a Sample");
    int x = 1;

    DataSet dset = GrdRentalTbl.DataSource as DataSet;

    for (int i = 0; i < dset.Tables[0].Rows.Count; i++)  
    {   // row
        IRow row = sheet1.CreateRow(i);
        for (int j = 0; j < dset.Tables[0].Rows[i].ItemArray.Length; j++)
        {
            row.CreateCell(j).SetCellValue(dset.Tables[0].Rows[i].ItemArray[j].ToString());
        }
    }
    FileStream sw = File.Create("test.xlsx"); // xls
    workbook.Write(sw);
    sw.Close();

    MetroMessageBox.Show(this, "Export완료", "Export");
}

    }
}
