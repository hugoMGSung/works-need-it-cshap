using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using TutorialApi.Models;

namespace TutorialApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public DepartmentController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"SELECT DepartmentId, DepartmentName 
                               FROM dbo.Department ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Department department)
        {
            string query = @"INSERT INTO dbo.Department
                             VALUES (@DepartmentName) ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(Department department)
        {
            string query = @"UPDATE dbo.Department
                                SET DepartmentName = @DepartmentName
                              WHERE DepartmentId = @DepartmentId ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    cmd.Parameters.AddWithValue("@DepartmentId", department.DepartmentId);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{Id}")]
        public JsonResult Delete(int Id)
        {
            string query = @"DELETE FROM dbo.Department
                              WHERE DepartmentId = @DepartmentId ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentId", Id);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }
    }
}
