using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TutorialApi.Helpers;
using TutorialApi.Models;
using TutorialApi.Services;

namespace TutorialApi.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var cryptedpass = Common.GetMd5Hash(MD5.Create(), model.Password);

            string query = @"SELECT [UserId]
                                  , [Username]
                                  , [Password]
                                  , [Role]
                               FROM [dbo].[User]
                              WHERE [Username] = @Username
                                AND [Password] = @Password ";
             
            DataTable table = new DataTable();
            string sqlDataSource = configuration.GetConnectionString("AllWebsCon");
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(sqlDataSource))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", model.Username);
                    cmd.Parameters.AddWithValue("@Password", cryptedpass);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                }
            }

            if (table.Rows.Count == 0)
                return NotFound(new { message = "User or password invalid" });

            var user = new User
            {
                UserId = (int)table.Rows[0].ItemArray[0],
                Username = table.Rows[0].ItemArray[1].ToString(),
                Password = table.Rows[0].ItemArray[2].ToString(),
                Role = table.Rows[0].ItemArray[3].ToString()
            };

            var token = TokenService.CreateToken(user);
            user.Password = string.Empty;
            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous()
        {
            return $"You are Anonymous";
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => $"Authenticated - {User.Identity.Name}";

        [HttpGet]
        [Route("tester")]
        [Authorize(Roles = "tester")]
        public string Tester()
        {
            return $"You are a Tester";
        }

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => $"Employee";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => $"Manager";
    }
}
