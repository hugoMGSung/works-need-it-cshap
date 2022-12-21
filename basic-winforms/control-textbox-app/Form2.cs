using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_textbox_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mtxPhoneNumber.Mask = "000-9000-0000";
        }

        private void mtxPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("숫자만 입력", this);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string val = mtxBirthday.Text + "\r\n" + mtxPhoneNumber.Text;
            MessageBox.Show(val);
        }
    }
}
