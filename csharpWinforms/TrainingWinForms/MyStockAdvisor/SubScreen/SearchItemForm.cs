using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using MyStockAdvisor.SubScreen;

namespace MyStockAdvisor
{
    public partial class SearchItemForm : MetroForm // MetroSetForm
    {
        LoadingForm form;

        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {
            DgvStocks.Font = new Font(@"NanumGothic", 9, FontStyle.Regular);
            TxtSearchItem.ImeMode = ImeMode.Hangul;
            // BackgroundWorker
            TxtSearchItem.Focus();            
        }

        /// <summary>
        /// 검색버튼 클릭시 처리할 것
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchItem.Text))
            {
                MessageBox.Show("검색어를 입력하세요");
                return;
            }

            // 비동기 시작
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            wc.DownloadStringCompleted += (send, arg) =>
            {
                form.Close();
                //MessageBox.Show();
                doc.LoadXml(arg.Result);

                XmlElement root = doc.DocumentElement;
                XmlNodeList items = doc.GetElementsByTagName("item");

                DgvStocks.Rows.Clear();

                foreach (XmlNode item in items)
                {
                    DgvStocks.Rows.Add(
                        item["isin"] == null ? "" : item["isin"].InnerText, 
                        item["issuDt"] == null ? "" : item["issuDt"].InnerText,
                        item["korSecnNm"] == null ? "" : item["korSecnNm"].InnerText, 
                        item["secnKacdNm"] == null ? "" : item["secnKacdNm"].InnerText, 
                        item["shotnIsin"] == null ? "" : item["shotnIsin"].InnerText);
                }

                DgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            };

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");
            str.Append("?serviceKey=qzyS5rrq0D4aHe%2B8lcYGp0LCf4hA0XrMG%2BbCDrg2TJMrBhTu82nhMSw71WQsM4CUj1EJc%2B3%2Fo%2BT9KOEZFJihPw%3D%3D"); //인증키
            str.Append("&secnNm=" + TxtSearchItem.Text);//종목명
            str.Append("&pageNo=1");//페이지 수
            str.Append("&numOfRows=200");//읽어올 데이터 수
            str.Append("&martTpcd=11");//주식시장종류 : 11은 유가증권시장

            wc.DownloadStringAsync(new Uri(str.ToString()));
            TxtSearchItem.Text = string.Empty;

            form = new LoadingForm();
            form.ShowDialog();
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }
    }
}
