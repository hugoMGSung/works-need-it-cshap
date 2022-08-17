using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sender = ConfigurationManager.AppSettings["SMTPSender"];
            string smtpHost = ConfigurationManager.AppSettings["SMTPHost"];
            int smtpPort = Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPort"]);
            string smtpId = ConfigurationManager.AppSettings["SMTPID"];
            string smtpPwd = ConfigurationManager.AppSettings["SMTPPassword"];
        }
    }
}
