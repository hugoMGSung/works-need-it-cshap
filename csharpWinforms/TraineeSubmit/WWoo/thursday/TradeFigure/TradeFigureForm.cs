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

namespace thursday.TradeFigure
{
    public partial class TradeFigureForm : Form
    {
        public TradeFigureForm()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formq forme = new formq();
            forme.Location = this.Location;
            forme.ShowDialog();
            this.Close();
        }

        private void TradeFigureForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://openapi.molit.go.kr/OpenAPI_ToolInstallPackage/service/rest/RTMSOBJSvc/getRTMSDataSvcAptTradeDev");
            str.Append("?serviceKey=VVS0fA04NvBe53ugZ5ClveVXr6wylvpIfQxHUKYtDVAd469z%2B3IGWcC796ybbvRLHjuEDxLX8sbKKp%2FFRtcxDw%3D%3D");
            str.Append("&pageNo=1");
            str.Append("&numOfRows=100");
            str.Append("&LAWD_CD=" + metroTextBox1.Text);
            str.Append("&DEAL_YMD=" + metroTextBox2.Text);

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            dataGridView1.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {

                    dataGridView1.Rows.Add(item["지역코드"].InnerText,
                                           item["법정동"].InnerText,
                                           item["아파트"].InnerText,
                                           item["건축년도"].InnerText,
                                           item["거래금액"].InnerText,
                                           item["전용면적"].InnerText,
                                           item["층"].InnerText,
                                           item["년"].InnerText,
                                           item["월"].InnerText,
                                           item["일"].InnerText,
                                           item["도로명"].InnerText,
                                           item["지번"].InnerText);
                }   
            }
            catch (NullReferenceException en)
            {
                MessageBox.Show($"에러발생!! {en.Message}", "에러!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

      

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                metroButton1_Click(sender, new EventArgs());
            }
        }
    }
    
}
