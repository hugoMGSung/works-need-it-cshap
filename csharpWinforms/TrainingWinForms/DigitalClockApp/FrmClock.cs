using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockApp
{
    public partial class FrmClock : Form
    {
        public FrmClock()
        {
            InitializeComponent();
        }

        private void FrmClock_Load(object sender, EventArgs e)
        {
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
