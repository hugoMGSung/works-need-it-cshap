using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace CnsLogTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Commons.LOGGER.Info("DataBase 접속 시도");
            string connString = "Data Source=localhost;Initial Catalog=OpenApiLab;Integrated Security=True";
            string strQuery = @"SELECT Id
                                     , EmpName
                                     , Salary
                                     , DeptName
                                     , Destination
                                  FROM TblEmployees";

            Commons.LOGGER.Info("DataBase 설정 및 쿼리 작성");

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strQuery, conn);
                    Commons.LOGGER.Warn("접속 실패가 발생할 수 있습니다. 주의하세요.");

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                        Console.WriteLine(reader["EmpName"]);
                    }
                }
                Commons.LOGGER.Info("DB 처리 완료!");
            }
            catch (Exception ex)
            {
                Commons.LOGGER.Error($"예외발생! : {ex}");
                Console.WriteLine("예외발생! 관리자에게 문의하세요!!");
            }
            Commons.LOGGER.Info("DataBase 접속 종료!!!!!");
        }
    }
}
