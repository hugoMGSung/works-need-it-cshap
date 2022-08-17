using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace ViewControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: // LargeIcon
                    listView1.View = View.LargeIcon;
                    break;
                case 1: // Details
                    listView1.View = View.Details;
                    break;
                case 2: // SmallIcon
                    listView1.View = View.SmallIcon;
                    break;
                case 3: // List
                    listView1.View = View.List;
                    break;
                case 4: // Tiles
                    listView1.View = View.Tile;
                    break;
                default:
                    listView1.View = View.Details;
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewSubItemCollection subItem = item.SubItems;
                label1.Text = string.Format("{0} 의 국가번호는 {1}", subItem[0].Text, subItem[1].Text);
            }
        }
    }
}
