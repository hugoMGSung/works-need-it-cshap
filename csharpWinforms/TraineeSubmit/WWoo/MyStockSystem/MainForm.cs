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

namespace MyStockSystem
{
    public partial class MainForm : MetroForm //Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Location = new Point(
            Screen.PrimaryScreen.Bounds.Width / 2,
            Screen.PrimaryScreen.Bounds.Height / 2);



        }

        private void button1_Click(object sender, EventArgs e)
        {
             

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void MtlItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchItemForm searchItem = new SearchItemForm();
            searchItem.Location = this.Location;
            searchItem.ShowDialog();
            this.Close();
        }
    }
}
