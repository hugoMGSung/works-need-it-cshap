using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thursday.SearchArea
{
    public partial class SearchAreaForm : Form
    {
        public int First;
        public int Second;
        public int Third;

        StringBuilder stringBuilder = new StringBuilder();

        public enum WideArea
        {
            서울특별시 = 11,
            부산광역시 = 26,
            대구광역시 = 27,
            인천광역시 = 28,
            광주광역시 = 29,
            대전광역시 = 30,
            울산광역시 = 31,
            세종특별자치시 = 36,
            경기도 = 41,
            강원도 = 42,
            충청북도 = 43,
            충청남도 = 44,
            전라북도 = 45,
            전라남도 = 46,
            경상북도 = 47,
            경상남도 = 48,
            제주특별자치도 = 50
        }

        public string[] bigadr = {"서울광역시","부산광역시","대구광역시","인천광역시",
                                  "울산광역시","광주광역시","대전광역시","세종특별자치시",
                                  "경기도","경상남도","경상북도","강원도","충청남도",
                                  "충청북도","전라남도","전라북도","제주특별자치도" };

        WideArea wideArea = new WideArea();

        public SearchAreaForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(bigadr);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formq forme = new formq();
            forme.Location = this.Location;
            forme.ShowDialog();
            this.Close();
        }

        private void SearchAreaForm_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.naver.com");
            textBox2.Text = "https://www.code.go.kr/stdcode/regCodeL.do";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = "";
            foreach (WideArea wideArea in Enum.GetValues(typeof(WideArea)))
            {
                if (wideArea.ToString() == comboBox1.Text)
                {
                    stringBuilder.Clear();
                    First = (int)wideArea;
                    stringBuilder.Append(First.ToString());

                    textBox1.Text = stringBuilder.ToString();
                }
            }


        }

        private void CmdButton(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton; //예2 현재 방식
            if (btn == btnForward) { webBrowser1.GoForward(); } //앞으로

            else if (btn == btnGo)
            {
                webBrowser1.Navigate(txtUrl.Text);
            } // URL 받아서 이동

            else webBrowser1.Stop();
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            txtUrl.Text = textBox2.Text;
        }
    }
}
