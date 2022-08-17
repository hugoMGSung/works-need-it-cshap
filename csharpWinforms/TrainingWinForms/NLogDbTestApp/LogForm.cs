using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLogDbTestApp
{
    public partial class LogForm : Form
    {
        Logger logger = LogManager.GetLogger("databaseLogger");

        public LogForm()
        {
            InitializeComponent();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            logger.Info("TEST!!!!");
            MessageBox.Show("일반로그 입력!");
        }

        private void BtnWarn_Click(object sender, EventArgs e)
        {
            logger.Warn(new Exception("MyWarning"), "Warning!!!!");
            MessageBox.Show("경고로그 입력!");
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            logger.Error(new Exception("MyError"), "Error!!!!!!!");
            MessageBox.Show("에러로그 입력!");
        }

        private void BtnFatal_Click(object sender, EventArgs e)
        {
            logger.Fatal(new Exception("MyFatal"), "Fatal!!!!!!!");
            MessageBox.Show("무지심각 오류로그 입력!");
        }
    }
}
