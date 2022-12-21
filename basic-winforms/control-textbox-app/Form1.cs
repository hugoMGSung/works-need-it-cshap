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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtNormal.Text = "부산시 금정구 ...";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("이름 : 성휴고");
            sb.AppendLine("나이 : 40대후반");
            sb.AppendLine("성별 : 남자겠지요");
            txtMultiline.Text = sb.ToString();
        }

        private void txtNormal_TextChanged(object sender, EventArgs e)
        {
            // 입력하면 오른쪽으로 이전 후 내용입력되도록 처리 (별로 안좋음)
            txtNormal.SelectionStart = txtNormal.TextLength;
            txtNormal.SelectionLength = 0;
        }
    }
}
