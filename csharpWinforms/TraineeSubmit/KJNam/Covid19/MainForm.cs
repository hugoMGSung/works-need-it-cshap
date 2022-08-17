using Covid19.SubItems;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            // 최초 실행시 프로그램 정중앙에서 실행
            this.Location = new Point(
                 Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                 Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
                 );
        }

        private void Covid19_Load(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            OtherCountry total = new OtherCountry();
            total.Location = this.Location;
            total.ShowDialog();

            this.Close();
        }

        private void Korea_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Korea kor = new Korea();
            kor.Location = this.Location;
            kor.ShowDialog();

            this.Close();
        }
    }
}
