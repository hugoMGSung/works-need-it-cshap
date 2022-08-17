using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using TutorialApi.Models;

namespace TutorialApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment env;

        public EmployeeController(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.configuration = configuration;
            this.env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"SELECT [EmployeeId]
                                  , [EmployeeName]
                                  , [Department]
                                  , CONVERT(VARCHAR(10), [DateOfJoining], 120) AS DateOfJoining
                                  , [PhotoFileName]
                              FROM [dbo].[Employee] ";

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
        public JsonResult Post(Employee emp)
        {
            string query = @"INSERT INTO [dbo].[Employee]
                                   ( [EmployeeName]
                                   , [Department]
                                   , [DateOfJoining]
                                   , [PhotoFileName])
                             VALUES
                                   ( @EmployeeName
                                   , @Department
                                   , @DateOfJoining
                                   , @PhotoFileName) ";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                    cmd.Parameters.AddWithValue("@Department", emp.Department);
                    cmd.Parameters.AddWithValue("@DateOfJoining", emp.DateOfJoining);
                    cmd.Parameters.AddWithValue("@PhotoFileName", emp.PhotoFileName);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(Employee emp)
        {
            string query = @"UPDATE [dbo].[Employee]
                               SET [EmployeeName] = @EmployeeName
                                  ,[Department] = @Department
                                  ,[DateOfJoining] = @DateOfJoining
                                  ,[PhotoFileName] = @PhotoFileName
                             WHERE [EmployeeId] = @EmployeeID";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                    cmd.Parameters.AddWithValue("@Department", emp.Department);
                    cmd.Parameters.AddWithValue("@DateOfJoining", emp.DateOfJoining);
                    cmd.Parameters.AddWithValue("@PhotoFileName", emp.PhotoFileName);
                    cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
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
            string query = @"DELETE FROM [dbo].[Employee]
                              WHERE [EmployeeId] = @EmployeeID";

            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", Id);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }

        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string fileName = postedFile.FileName;
                var physicalPath = $"{env.ContentRootPath}/Photos/{fileName}";

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(fileName);
            }
            catch (Exception ex)
            {
                return new JsonResult("anonymous.jpg");
            }
        }
    }
}
