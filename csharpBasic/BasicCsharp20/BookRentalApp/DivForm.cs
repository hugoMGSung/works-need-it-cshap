using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookRentalApp
{
    public partial class DivForm : MetroFramework.Forms.MetroForm
    {
        string mode = "";

        public DivForm()
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
                string strQuery = "SELECT Division, Names FROM divtbl ";
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl";
            }

            mode = "";
        }

        private void UpdateProcess()
        {
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
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
                        cmd.CommandText = "UPDATE divtbl SET Names = @names WHERE Division = @division";
                    }
                    else if (mode == "INSERT")
                    {
                        cmd.CommandText = "INSERT INTO divtbl VALUES (@division, @names)";
                    }

                    MySqlParameter paramName = new MySqlParameter("@names", MySqlDbType.VarChar, 45);
                    paramName.Value = (TxtNames.Text);
                    cmd.Parameters.Add(paramName);
                    MySqlParameter paramDiv = new MySqlParameter("@division", MySqlDbType.VarChar);
                    paramDiv.Value = TxtDivision.Text;
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

        private void TxtDivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtNames.Focus();
            }
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
                    paramDiv.Value = TxtDivision.Text;
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
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false;
            mode = "INSERT";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdateProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtDivision.Text = TxtNames.Text = string.Empty;
            TxtDivision.ReadOnly = false;
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();
                TxtDivision.ReadOnly = true;
                TxtNames.Text = data.Cells[1].Value.ToString();
                mode = "UPDATE";
            }
        }

        private void DivForm_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
