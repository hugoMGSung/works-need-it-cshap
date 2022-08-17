using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BookRentalApp
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        string mode = "";

        public UserForm()
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
                string strQuery = "SELECT id, userID, password  FROM userTbl ";
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "userTbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "userTbl";
            }

            mode = "";
        }

        private void UpdateProcess()
        {
            if (string.IsNullOrEmpty(TxtId.Text) || string.IsNullOrEmpty(TxtUserId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
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
                        cmd.CommandText = "UPDATE userTbl SET " +
                                          "       userID = @userID, " +
                                          "       password = @password " +
                                          " WHERE id = @id";
                    }
                    else if (mode == "INSERT")
                    {
                        cmd.CommandText = "INSERT INTO userTbl (userID, password) VALUES (@userID, @password)";
                    }

                    MySqlParameter parmUserID = new MySqlParameter("@userID", MySqlDbType.VarChar, 12);
                    parmUserID.Value = TxtUserId.Text;
                    cmd.Parameters.Add(parmUserID);
                    MySqlParameter parmPass = new MySqlParameter("@password", MySqlDbType.VarChar);
                    string strTemp = TxtPassword.Text;
                    //var mdHash = MD5.Create();
                    //var passResult = Commons.GetMd5Hash(mdHash, strTemp);
                    parmPass.Value = strTemp; //  passResult;
                    cmd.Parameters.Add(parmPass);

                    MySqlParameter id = new MySqlParameter("@id", MySqlDbType.Int32);
                    id.Value = TxtId.Text;
                    cmd.Parameters.Add(id);


                    cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "로그인 성공", "로그인");
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
                TxtUserId.Focus();
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
                    cmd.CommandText = "DELETE userTbl WHERE id = @id";
                    MySqlParameter paramDiv = new MySqlParameter("@id", MySqlDbType.Int32);
                    paramDiv.Value = TxtId.Text;
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
            TxtId.Text = TxtUserId.Text = string.Empty;
            TxtId.ReadOnly = false;
            mode = "INSERT";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdateProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtId.Text = TxtUserId.Text = string.Empty;
            TxtId.ReadOnly = false;
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtId.Text = data.Cells[0].Value.ToString();
                TxtId.ReadOnly = true;
                TxtUserId.Text = data.Cells[1].Value.ToString();
                TxtPassword.Text = data.Cells[2].Value.ToString();
                mode = "UPDATE";
            }
        }

        private void DivForm_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
