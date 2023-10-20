using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf13_bookrentalshop.Helpers;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
        #region < 각화면 폼 >
        FrmGenre frmGenre = null;  // 책장르관리 객체변수
        FrmBooks frmBooks = null;  // 챌정보관리
        #endregion

        #region < 생성자 >

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region < 이벤트 핸들러 영역 >

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            LblUserId.Text = Commons.LoginID;
            LblLoginDatetime.Text = "/" + DateTime.Now.ToString();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료!
        }

        private void MniGenre_Click(object sender, EventArgs e)
        {
            //FrmGenre frm = new FrmGenre();
            //frm.TopLevel = false;
            //this.Controls.Add(frm);
            //frm.Show();
            frmGenre = ShowActiveForm(frmGenre, typeof(FrmGenre)) as FrmGenre;
        }

        #region < 임시 Collapse >

        private void MniBookInfo_Click(object sender, EventArgs e)
        {
            frmBooks = ShowActiveForm(frmBooks, typeof(FrmBooks)) as FrmBooks;
        }

        private void MniMember_Click(object sender, EventArgs e)
        {

        }

        private void MniRental_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        private Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 한버도 자식창을 안열었으면
            {
                form = (Form)Activator.CreateInstance(type); // 리플렉션으로 타입에 맞는 창을 새로 생성
                form.MdiParent = this; // FrmMain이 MDI부모
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed) // 한번 닫혔다.
                {
                    form = (Form)Activator.CreateInstance(type); // 리플렉션으로 타입에 맞는 창을 새로 생성
                    form.MdiParent = this; // FrmMain이 MDI부모
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창이 열려있으면
                {
                    form.Activate(); // 화면이 있으면 그 화면을 활성화
                }
            }

            return form;
        }
    }
}
