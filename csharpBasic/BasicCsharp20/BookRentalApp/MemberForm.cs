using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalApp
{
    public partial class MemberForm : MetroFramework.Forms.MetroForm
    {
        string mode = "";

        public MemberForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'bookrentalshopDataSet.divtbl' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.divtblTableAdapter.Fill(this.bookrentalshopDataSet.divtbl);
            UpdateData();
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                conn.Open();
                string strQuery = "SELECT Idx, Names, Levels, Addr, Mobile, Email FROM membertbl ";
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "membertbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "membertbl";
            }


            SetColumnHeaders();
            mode = "";
        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column = GrdDivTbl.Columns[0];
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdDivTbl.Columns[1];
            column.Width = 110;
            column.HeaderText = "이름";
            column = GrdDivTbl.Columns[2];
            column.Width = 60;
            column.HeaderText = "등급";
            column = GrdDivTbl.Columns[3];
            column.Width = 120;
            column.HeaderText = "주소";
            column = GrdDivTbl.Columns[4];
            column.Width = 100;
            column.HeaderText = "핸드폰";
            column = GrdDivTbl.Columns[5];
            column.Width = 170;
            column.HeaderText = "이메일";
        }

        private void UpdateProcess()
        {
            if (string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtAddr.Text) 
                || string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text)
                || CboLevels.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (mode == "UPDATE")
                    {
                        cmd.CommandText = "UPDATE dbo.membertbl " +
                                          "   SET Names = @Names " + // -- varchar(45),>
                                          "     , Levels = @Levels " + // -- char(1),>
                                          "     , Addr = @Addr " +  //-- varchar(100),>
                                          "     , Mobile = @Mobile " + // -- varchar(13),>
                                          "     , Email = @Email " +  // -- varchar(50),>
                                          " WHERE Idx = @Idx ";
                    }
                    else if (mode == "INSERT")
                    {
                        cmd.CommandText = "INSERT INTO " +
                                          "  membertbl (Names, Levels, Addr, Mobile, Email) " +
                                          "     VALUES (@Names, @Levels, @Addr, @Mobile, @Email) ";
                    }

                    MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
                    paramNames.Value = (TxtNames.Text);
                    cmd.Parameters.Add(paramNames);

                    MySqlParameter paramLevels = new MySqlParameter("@Levels", MySqlDbType.VarChar, 1);
                    paramLevels.Value = CboLevels.SelectedItem;
                    cmd.Parameters.Add(paramLevels);

                    MySqlParameter paramAddr = new MySqlParameter("@Addr", MySqlDbType.VarChar, 100);
                    paramAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(paramAddr);

                    MySqlParameter paramMobile = new MySqlParameter("@Mobile", MySqlDbType.VarChar, 13);
                    paramMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(paramMobile);

                    MySqlParameter paramEmail = new MySqlParameter("@Email", MySqlDbType.VarChar, 50);
                    paramEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(paramEmail);

                    if (mode == "UPDATE")
                    {
                        MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32);
                        paramIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(paramIdx);
                    }

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

        private void TxtDivision_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (mode != "UPDATE")
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DeleteProcess();
            }
        }

        private void DeleteProcess()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNECTIONSTRING))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE divtbl WHERE Division = @division";
                    MySqlParameter paramDiv = new MySqlParameter("@division", MySqlDbType.VarChar);
                    paramDiv.Value = TxtIdx.Text;
                    cmd.Parameters.Add(paramDiv);


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
            TxtIdx.Text = TxtNames.Text = TxtAddr.Text = TxtMobile.Text = TxtEmail.Text = string.Empty;
            CboLevels.Text = "";
            mode = "INSERT";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdateProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtIdx.Text = TxtNames.Text = string.Empty;
            TxtIdx.ReadOnly = false;
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtNames.Text = data.Cells[1].Value.ToString();
                CboLevels.Text = data.Cells[2].Value.ToString();
                TxtAddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();
                mode = "UPDATE";
            }
        }

        private void MemberForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
