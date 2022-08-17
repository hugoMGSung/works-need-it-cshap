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

namespace MyStockSystem
{
    public partial class SearchItemForm : MetroForm
    {
        public SearchItemForm()
        {
            InitializeComponent();
            

        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Location = this.Location;
            mainForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MtlSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient(){Encoding = Encoding.UTF8};
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");
            str.Append("?serviceKey=VVS0fA04NvBe53ugZ5ClveVXr6wylvpIfQxHUKYtDVAd469z%2B3IGWcC796ybbvRLHjuEDxLX8sbKKp%2FFRtcxDw%3D%3D");
            str.Append("&secnNm=" + Mtltxt.Text);
            str.Append("&pageNo=1");
            str.Append("$numOfRows=200");
            str.Append("&martTpcd=11");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items= doc.GetElementsByTagName("item");

            DGV.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {

                    DGV.Rows.Add(item["isin"].InnerText,
                                 /*item["issuDt"] == null ? string.Empty : */item["issuDt"].InnerText,
                                 item["korSecnNm"].InnerText,
                                 item["secnKacdNm"].InnerText,
                                 item["shotnIsin"].InnerText);
                }
            }
            catch (NullReferenceException en)
            {
                MessageBox.Show($"에러발생!! {en.Message}", "에러!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Mtltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MtlSearch_Click(sender, new EventArgs());
            }
        }
    }
}
