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




namespace WinFormTest.SubItem
{
    public partial class DustForm : MetroForm
    {
        public DustForm()
        {
            InitializeComponent();
        }

        private void DustForm_Load(object sender, EventArgs e)
        {
            metroGrid1.Font = new Font("NanumGothic", 9, FontStyle.Regular);
            ItemSearch.Font = new Font("NanumGothic", 10, FontStyle.Regular);
        }

        private void metroTile1_Click(object sender, EventArgs e)   // 클릭시 요청변수 받아옴
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/AirQualityInfoService/getAirQualityInfoClassifiedByStation"); // 대기질 api 주소
            str.Append("?serviceKey=g3WYtEP8jFs365eer9YZS7bzG1TK8V7773NBlAUtbhKFHQeUq3KVeig6x71WUumuc%2FCIvBFQRA64VJSjmYyHEg%3D%3D");
            str.Append("&pageNo=1");    // 페이지 수
            str.Append("&numOfRows=29"); // 읽어올 데이터 수

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            
            metroGrid1.Rows.Clear();    
            
            foreach (XmlNode item in items)     // 그리드에 출력값
            {
                if (TextSearchItem.Text == item["site"].InnerText)
                {
                    metroGrid1.Rows.Add(item["site"].InnerText,
                    item["controlnumber"].InnerText,
                    item["o3"].InnerText,       // 오존
                    item["pm25"].InnerText,     // 초미세먼지
                    item["pm10"].InnerText);    // 미세먼지
                }
                else if (TextSearchItem.Text == "")
                {
                    metroGrid1.Rows.Add(item["site"].InnerText,
                    item["controlnumber"].InnerText,
                    item["o3"].InnerText,       // 오존
                    item["pm25"].InnerText,     // 초미세먼지
                    item["pm10"].InnerText);    // 미세먼지
                }
                else if (TextSearchItem.Text == "빈칸 - 전체 결과 검색")
                {
                    metroGrid1.Rows.Add(item["site"].InnerText,
                    item["controlnumber"].InnerText,
                    item["o3"].InnerText,       // 오존
                    item["pm25"].InnerText,     // 초미세먼지
                    item["pm10"].InnerText);    // 미세먼지
                }
            }
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }

        private void TextSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter
            {
                metroTile1_Click(sender, new EventArgs());
            }
        }

        private void TextSearchItem_Click(object sender, EventArgs e)
        {
            TextSearchItem.Clear();            
        }
    }
}
