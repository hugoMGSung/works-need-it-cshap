using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DbHandlingWebApp
{
    public partial class FrmDbConn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConn_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                //LblResult.Text = conn.State.ToString();
                var query = @"Insert Memos 
                               Values
                              ('성명건', 'personar95@naver.com', '성명건입니다.', GetDate(), '127.0.0.1')";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    LblResult.Text = "데이터 저장완료";
                }
                catch (Exception ex)
                {
                    LblResult.Text = $"오류 {ex}";
                }
            }
        }
    }
}