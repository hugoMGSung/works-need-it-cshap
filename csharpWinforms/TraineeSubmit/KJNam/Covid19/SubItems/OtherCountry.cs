using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Covid19.SubItems
{
    public partial class OtherCountry : MetroForm
    {
        public OtherCountry()
        {
            InitializeComponent();
        }

        private void OtherCountry_Load(object sender, EventArgs e)
        {
            // DgvSearchItems는 그리드 이름
            DgvSearchItems.Font = new Font("NanumGothic", 10, FontStyle.Regular);
        }

        private void butHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm home = new MainForm();
            home.Location = this.Location;
            home.ShowDialog();

            this.Close();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19NatInfStateJson");
            str.Append("?serviceKey=GwVQ7TaRbHq9SHcv0FVZWp9B671xagge2Ur5Rd8BHBnjf8YXMz%2BR1AE5TTWI7N5ibyOyI73%2BEwG5LcHd057JPQ%3D%3D");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            DgvSearchItems.Rows.Clear();
            foreach (XmlNode item in items)
            {
                if(TxtSearchItem.Text == item["nationNm"].InnerText)
                {
                    DgvSearchItems.Rows.Add(
                    item["nationNm"].InnerText, // 국가명
                    item["nationNmEn"].InnerText, // 국가명 영문
                    item["natDefCnt"].InnerText, // 확진자 수
                    item["natDeathCnt"].InnerText, // 사망자수
                    item["stdDay"] == null ? string.Empty : item["stdDay"].InnerText); // 기준일시
                }
                else if (TxtSearchItem.Text == "")
                {
                    DgvSearchItems.Rows.Add(
                    item["nationNm"].InnerText, // 국가명
                    item["nationNmEn"].InnerText, // 국가명 영문
                    item["natDefCnt"].InnerText, // 확진자 수
                    item["natDeathCnt"].InnerText, // 사망자수
                    item["stdDay"] == null ? string.Empty : item["stdDay"].InnerText); // 기준일시
                }
            }
            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter
            {
                butSearch_Click(sender, new EventArgs());
            }
        }
    }
}
