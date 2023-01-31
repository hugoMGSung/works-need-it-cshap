using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_lists_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbMembership.Items.Add("VVIP");
            lsbMembership.Items.Add("VIP");
            lsbMembership.Items.Add("Platnum");
            lsbMembership.Items.Add("Gold");
            lsbMembership.Items.Add("Silver");
            lsbMembership.Items.Add("Bronze");
            lsbMembership.Items.Add("Available");

            // 기본 선택
            lsbMembership.SelectedIndex = 6;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string resMembership = lsbMembership.SelectedItem as string;
            MessageBox.Show(resMembership);
        }

        
    }
}
