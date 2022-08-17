using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace DbHandlingWebApp
{
    public partial class FrmMemoView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 요청입니다");
                Response.End();
            }
            else
            {
                var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString; // 1
                using (var conn = new SqlConnection(connString)) // 1
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open(); // 1

                    SqlCommand cmd = new SqlCommand("ViewMemo", conn); // 첫번째 파라미터만 변경
                    cmd.CommandType = System.Data.CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt32(Request["Num"]));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        LblNum.Text = Request["Num"];
                        LblName.Text = reader["Name"].ToString();
                        LblEmail.Text = reader["Email"].ToString();
                        LblTitle.Text = reader["Title"].ToString();
                        LblPostDate.Text = reader["PostDate"].ToString();
                        LblPostIP.Text = reader["PostIP"].ToString();
                    }

                    reader.Close();
                }
            }
        }
    }
}
