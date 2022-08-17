using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("진짜 닫을래?", "진짜경고", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false; // 취소를 안시켜서 종료
            }
            else
            {
                e.Cancel = true; // 취소시키니까 종료안됨
            }
        }
    }
}
