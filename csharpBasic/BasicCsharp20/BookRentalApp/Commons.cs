using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace BookRentalApp
{
    public static class Commons
    {
        public static string USERID = string.Empty;  // 사용자 아이디

        public static string CONNECTIONSTRING =
            "Data Source=127.0.0.1;Port=3306;Database=bookrentalshop;Uid=root;Password=maria_p@ssw0rd!";

        public static string GetMd5Hash(MD5 md5Hash, string input)
        { 
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input)); 
            // Create a new Stringbuilder to collect the bytes 
            // and create a string. 
            StringBuilder sBuilder = new StringBuilder(); 
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++) { 
                sBuilder.Append(data[i].ToString("x2")); 
            } 
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }
}
