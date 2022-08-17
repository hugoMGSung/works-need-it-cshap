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
using WinFormTest.SubItem;

namespace WinFormTest
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Location = new Point(
               Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
               Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            DustForm dustForm = new DustForm();
            dustForm.Location = this.Location;
            dustForm.ShowDialog();

            this.Close();
        }


    }
}
