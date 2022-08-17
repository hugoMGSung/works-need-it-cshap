using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TravelInfoApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            TxtSearch.Focus();

            GetCountryData();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetCountryData();
        }

        private void GrdCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show($"{GrdCountry.Rows[e.RowIndex].Cells[3].Value.ToString()}");
                //LbData.Text = GrdCountry.Rows[e.RowIndex].Cells[3].Value.ToString();

                string BasicData = GrdCountry.Rows[e.RowIndex].Cells[3].Value.ToString();

                string Str = string.Empty; // <br> 짜른 문자열 저장
                int index;
                while((index = BasicData.IndexOf("<br>")) != -1)
                {
                    Str += BasicData.Substring(0, index) + "\r\n";
                    BasicData = BasicData.Substring(index + 4);
                }
                Str += BasicData;

                Str = DeleteHtml(Str);
                Str = Str.Replace("&nbsp;", string.Empty); // &nbsp; 정리

                LbData.Text = Str;

                string imgUrl = GrdCountry.Rows[e.RowIndex].Cells[4].Value.ToString();
                Bitmap image = GetImage(imgUrl);

                if(image != null)
                {
                    Bitmap resizeImg = new Bitmap(image, 280, 160);

                    ImgCountry.Image = resizeImg;
                    ImgCountry.Visible = true;
                    ImgBox.Visible = true;
                }
                else
                {
                    ImgCountry.Visible = false;
                    ImgBox.Visible = false;
                }

                GetCovid(e);
            }
        }

        private string DeleteHtml(string str)
        {
            return System.Text.RegularExpressions.Regex.Replace(str, @"<(.|\n)*?>", string.Empty);
        }

        private void GetCountryData() // 각 국가들의 정보를 최초에 불러옴
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/1262000/CountryBasicService/getCountryBasicList"); // 기본 URL
            str.Append("?serviceKey=C%2Fd4GdNE5oLhFZ5rM%2FyMrKeTyjEyXCbO1tC7PSppGVUGa3q8pLoID1qvSgcLidUsPi98Oiej8Gy0uy8Mf4dLhg%3D%3D"); // 인증키
            str.Append("&numOfRows=1000"); // 읽어올 데이터 수
            str.Append("&pageNo=1"); // 페이지 수
            if (!string.IsNullOrEmpty(TxtSearch.Text))
                str.Append($"&countryName={TxtSearch.Text}");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlNodeList items = doc.GetElementsByTagName("item");

            GrdCountry.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    GrdCountry.Rows.Add(
                        item["countryEnName"].InnerText,
                        item["countryName"].InnerText,
                        item["continent"].InnerText,
                        item["basic"].InnerText,
                        item["imgUrl"].InnerText);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GrdCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public Bitmap GetImage(string imgUrl)
        {
            try
            {
                WebClient Downloader = new WebClient();
                Stream ImageStream = Downloader.OpenRead(imgUrl);
                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
                return DownloadImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void GetCovid(DataGridViewCellEventArgs e) // 각 국가들의 코로나 현황을 불러옴
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19NatInfStateJson"); // 기본 URL
            str.Append("?serviceKey=C%2Fd4GdNE5oLhFZ5rM%2FyMrKeTyjEyXCbO1tC7PSppGVUGa3q8pLoID1qvSgcLidUsPi98Oiej8Gy0uy8Mf4dLhg%3D%3D"); // 인증키

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlNodeList items = doc.GetElementsByTagName("item");

            try
            {
                foreach (XmlNode item in items)
                {
                    if (item["nationNmEn"].InnerText == GrdCountry.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        TxtDecide.Text = item["natDefCnt"].InnerText + "명";
                        TxtDeath.Text = item["natDeathCnt"].InnerText + "명";
                        if(item["natDeathRate"].InnerText.Length > 4)
                            TxtRate.Text = item["natDeathRate"].InnerText.Substring(0, 4) + "%";
                        else
                            TxtRate.Text = item["natDeathRate"].InnerText + "%";

                        break;
                    }
                    else
                    {
                        TxtDecide.Text = "정보 없음";
                        TxtDeath.Text = "정보 없음";
                        TxtRate.Text = "정보 없음";
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LbData_DoubleClick(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, LbData.Text, "국가 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Infomation infomation = new Infomation(LbData.Text);
            infomation.ShowDialog();
        }
    }
}
