using System;
using System.Windows.Forms;

namespace wf05_login
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "abcd" && TxtPass.Text == "1234")
            {
                LblResult.Text = "로그인 성공";
                MessageBox.Show("로그인 성공!!", "로그인", MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
            }
            else
            {
                LblResult.Text = "로그인 실패";
                MessageBox.Show("로그인 실패!!", "로그인", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
