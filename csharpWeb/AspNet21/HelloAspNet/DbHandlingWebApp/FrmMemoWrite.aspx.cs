﻿using Dapper.Bulk;
using DbHandlingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DbHandlingWebApp
{
    public partial class FrmMemoWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Memo> lists = new List<Memo>();

            for (int i = 0; i < 1000000; i++)
            {
                var temp = new Memo()
                {
                    Num = i + 11,
                    Name = $"TEST {i + 1}",
                    Email = $"test_{i + 1}@naver.com",
                    Title = $"Test Title {i + 1}",
                    PostDate = DateTime.Now,
                    PostIP = "127.0.0.1"
                };
                lists.Add(temp);
            }

            DateTime startTime = DateTime.Now;
            LblResult.Text = $"{lists.Count}";

            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.BulkInsert(lists);
            }

            TimeSpan times = DateTime.Now - startTime;

            LblResult.Text = $"Done in {times}";
        }

        protected void BtnWrite_Click(object sender, EventArgs e)
        {
            Memo memos = new Memo();
            memos.Name = TxtName.Text;
            memos.Email = TxtEmail.Text;
            memos.Title = TxtTitle.Text;
            memos.PostDate = DateTime.Now;
            memos.PostIP = Request.UserHostAddress;

            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("WriteMemo", conn); // 저장프로시저
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    //var query = @"Insert Memos (Name, Email, Title, PostDate, PostIP)
	                //                Values (@Name, @Email, @Title, @PostDate, @PostIP)";
                    //SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@Name", memos.Name);
                    cmd.Parameters.AddWithValue("@Email", memos.Email);
                    cmd.Parameters.AddWithValue("@Title", memos.Title);
                    cmd.Parameters.AddWithValue("@PostDate", memos.PostDate);
                    cmd.Parameters.AddWithValue("@PostIP", memos.PostIP);

                    cmd.ExecuteNonQuery();

                    LblResult.Text = "저장되었습니다.";
                }
                catch (Exception ex)
                {
                    LblResult.Text = $"예외발생 : {ex}";
                }
            }
        }

        protected void BtnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}