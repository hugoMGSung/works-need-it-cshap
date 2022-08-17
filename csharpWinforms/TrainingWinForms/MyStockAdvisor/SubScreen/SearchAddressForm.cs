using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyStockAdvisor
{
    public partial class SearchAddressForm : MetroForm // MetroSetForm
    {
        public SearchAddressForm()
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

            InitComboSidoData();
        }

        private void InitComboSidoData()
        {
            // 시도 데이터 만들기
            var dicSido = new Dictionary<string, string>();
            dicSido.Add("선택", "00");
            dicSido.Add("서울특별시", "11");
            dicSido.Add("부산광역시", "21");
            dicSido.Add("대구광역시", "22");
            dicSido.Add("인천광역시", "23");
            dicSido.Add("광주광역시", "24");
            dicSido.Add("대전광역시", "25");
            dicSido.Add("울산광역시", "26");
            dicSido.Add("세종특별자치시", "29");
            dicSido.Add("경기도", "31");
            dicSido.Add("강원도", "32");
            dicSido.Add("충청북도", "33");
            dicSido.Add("충청남도", "34");
            dicSido.Add("전라북도", "35");
            dicSido.Add("전라남도", "36");
            dicSido.Add("경상북도", "37");
            dicSido.Add("경상남도", "38");
            dicSido.Add("제주특별자치도", "39");

            CboSido.DataSource = new BindingSource(dicSido, null);
            CboSido.DisplayMember = "Key";
            CboSido.ValueMember = "Value";
        }

        /// <summary>
        /// 검색버튼 클릭시 처리할 것
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };

            /**
                http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo
                ?serviceKey=qzyS5rrq0D4aHe%2B8lcYGp0LCf4hA0XrMG%2BbCDrg2TJMrBhTu82nhMSw71WQsM4CUj1EJc%2B3%2Fo%2BT9KOEZFJihPw%3D%3D
                &pageNo=1
                &numOfRows=10
                &resultType=json&
             */
            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo");
            str.Append("?serviceKey=qzyS5rrq0D4aHe%2B8lcYGp0LCf4hA0XrMG%2BbCDrg2TJMrBhTu82nhMSw71WQsM4CUj1EJc%2B3%2Fo%2BT9KOEZFJihPw%3D%3D"); //인증키
            str.Append("&pageNo=1");//페이지 수
            str.Append("&numOfRows=10");//읽어올 데이터 수
            str.Append("&resultType=json");//결과타입 json
            
            string result = wc.DownloadString(str.ToString());
            JObject obj = JObject.Parse(result);
            //dynamic json = JsonConvert.DeserializeObject(result);
            var info = obj.SelectToken("getGalmaetGilInfo");
            //var items = obj.SelectToken("item");
            var items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());

            foreach (var item in items)
            {
                // TODO
                System.Diagnostics.Debug.WriteLine(item);
            }
            DgvStocks.Rows.Clear();

            //foreach (XmlNode item in items)
            //{
            //    DgvStocks.Rows.Add(item["isin"].InnerText, item["issuDt"].InnerText, 
            //        item["korSecnNm"].InnerText, item["secnKacdNm"].InnerText, item["shotnIsin"].InnerText);
            //}

            DgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void CboSido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboSido.SelectedIndex == 0) { }
            else
            {
                //MessageBox.Show(CboSido.SelectedValue.ToString());
                // 받은 값으로 시구군코드를 변경함
                var selSidoCode = CboSido.SelectedValue.ToString();

                // 

            }
            
        }
    }
}
