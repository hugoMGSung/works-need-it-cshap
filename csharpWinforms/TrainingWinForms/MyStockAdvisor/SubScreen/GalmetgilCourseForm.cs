using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using MyStockAdvisor.SubScreen;

namespace MyStockAdvisor
{
    public partial class GalmetgilCourseForm : MetroForm // MetroSetForm
    {
        LoadingForm form;

        public GalmetgilCourseForm()
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
        }

        /// <summary>
        /// 검색버튼 클릭시 처리할 것
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };


            wc.DownloadStringCompleted += (s, a) =>
            {
                form.Close();
                form.Dispose();

                JObject obj = JObject.Parse(a.Result); // result);
                                                 //dynamic json = JsonConvert.DeserializeObject(result);
                var info = obj.SelectToken("getGalmaetGilInfo");
                //var items = obj.SelectToken("item");
                var items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());

                DgvStocks.Rows.Clear();

                foreach (JToken item in items)
                {
                    // 7개 값  kosNm, kosType, kosTxt, img, txt1, title, txt2
                    DgvStocks.Rows.Add(item.SelectToken("kosNm").ToString(),
                                       item.SelectToken("kosType").ToString(),
                                       item.SelectToken("kosTxt").ToString(),
                                       item.SelectToken("img").ToString(),
                                       item.SelectToken("txt1").ToString(),
                                       item.SelectToken("title").ToString(),
                                       item.SelectToken("txt2").ToString());
                }

                DgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            };

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
            
            wc.DownloadStringAsync(new Uri(str.ToString()));

            form = new LoadingForm();
            form.ShowDialog();
        }

        private void DgvStocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selvalue = DgvStocks.Rows[e.RowIndex].Cells[3].Value.ToString();
            //MessageBox.Show(selvalue);
            WebScreen screen = new WebScreen();
            screen.ParentUrl = selvalue;
            screen.ShowDialog();
        }
    }
}
