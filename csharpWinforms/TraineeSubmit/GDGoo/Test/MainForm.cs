using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Test.Items;

namespace Test
{
    public partial class MainForm : MetroForm
    {
        SearchMode searchMode = SearchMode.NONE;
        string ClickCountryName = "";
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SearchText.Focus();
            GetData();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchMode = SearchMode.SELECT;
            GetData();
        }
        private void GetData()
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/1262000/CountryBasicService/getCountryBasicList");//Open API 기본 url
            str.Append("?serviceKey=UB9SZcaYa9xzJQK8qL5DsjCMYYk%2B2qa20%2FuN1g1dVYmTHqk5fe862uloHnBeo%2BV85dezYbZqKhjLgIKKaS3QDw%3D%3D");//일반 인증키
            str.Append("&numOfRows=300");
            str.Append("&pageNo=1");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");
            //조건에 따른 Get Data
            try
            {
                if (searchMode == SearchMode.NONE)
                {
                    DataGrid.Rows.Clear();
                    foreach (XmlNode item in items)
                    {
                        DataGrid.Rows.Add(
                                   item["countryName"].InnerText,
                                   item["countryEnName"].InnerText,
                                   item["continent"].InnerText);
                    }
                }
                else if (searchMode == SearchMode.SELECT)
                {
                    DataGrid.Rows.Clear();
                    foreach (XmlNode item in items)
                    {
                        if (item["countryName"].InnerText.Contains(SearchText.Text))
                        {
                            DataGrid.Rows.Add(
                                item["countryName"].InnerText,
                                item["countryEnName"].InnerText,
                                item["continent"].InnerText);
                        }
                    }
                }
                else if (searchMode == SearchMode.CLICK)
                {
                    foreach (XmlNode item in items)
                    {
                        if (item["countryName"].InnerText.Contains(ClickCountryName))
                        {
                            //getData
                            string imgUrl = item["imgUrl"].InnerText;
                            string id = item["id"].InnerText;
                            string countryNmae = item["countryName"].InnerText;
                            string countryEnName = item["countryEnName"].InnerText;
                            string continent = item["continent"].InnerText;
                            string basic = item["basic"].InnerText;

                            //이미지 url-> bitmap
                            WebClient client = new WebClient();
                            byte[] myDataBuffer = client.DownloadData(imgUrl);
                            Stream stream = new MemoryStream();
                            stream.Write(myDataBuffer, 0, myDataBuffer.Length);
                            CountryImage.Image = Image.FromStream(stream, true);
                            string tbasic = Strip(basic);
                            //base text 수정
                            //string tbasic= Strip(basic);
                            //char[] transBasic = tbasic.ToCharArray();
                            //int count = 0;
                            //int indexCount = 0;
                            //for (int i = 0; i < (transBasic.Length)+indexCount ; i++)
                            //{
                            //    if (transBasic[i] == '\n' || count == 31)
                            //    {
                            //        count = 0;
                            //    }
                            //    if (count == 30)
                            //    {
                            //        tbasic = tbasic.Insert(i+indexCount, "\n");
                            //        indexCount++;
                            //    }
                            //    count++;
                            //}
                            //SetData
                            tCountryNmae.Text = countryNmae;
                            tCountryEnName.Text = countryEnName;
                            tContinent.Text = continent;
                            tBasic.Text = tbasic;

                        }
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private string Strip(string basic)
        {
            return System.Text.RegularExpressions.Regex.Replace(basic, @"<(.|\n)*?>", string.Empty);
        }

        private void SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = DataGrid.Rows[e.RowIndex];
                ClickCountryName = data.Cells[0].Value.ToString();
                searchMode = SearchMode.CLICK;
                GetData();
            }
        }

    }
}
