using System;
using System.Windows.Forms;

namespace BookRentalApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        int mdiID = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
        }

        private void InitFormControl(Form form, String strTitle)
        {
            form.MdiParent = this;
            form.Text = strTitle;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void MnuItemCodeMng_Click(object sender, EventArgs e)
        {
            CloseForms();

            DivForm form = new DivForm();
            InitFormControl(form, "구분코드 관리");
        }



        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "종료하겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                CloseForms();
                e.Cancel = false;
                Environment.Exit(0);
            } else
            {
                e.Cancel = true;
            }
        }

        private void CloseForms()
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void MnuItemMemerMng_Click(object sender, EventArgs e)
        {
            CloseForms();

            MemberForm form = new MemberForm();
            InitFormControl(form, "회원관리");
        }

        private void MnuItemRentalMng_Click(object sender, EventArgs e)
        {
            CloseForms();
            RentalForm form = new RentalForm();
            InitFormControl(form, "대여관리");
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LblDisplayUserID.Text = Commons.USERID;
        }

        private void a(object sender, EventArgs e)
        {

        }

        private void MnuItemLogin_Click(object sender, EventArgs e)
        {
            CloseForms();
            UserForm form = new UserForm();
            InitFormControl(form, "사용자관리");
        }
    }
}
