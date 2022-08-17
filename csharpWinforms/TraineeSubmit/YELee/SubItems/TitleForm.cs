using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Xml;
using System.Net;
using System.Web;

namespace MyMovieApp.SubItems
{
    public partial class TitleForm : MetroForm
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {
            DgvSearchItems.Font = new Font(@"NanumGothic", 9, FontStyle.Italic);
        }

        private void TxtSearchItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://www.kobis.or.kr/kobisopenapi/webservice/rest/movie/searchMovieList.xml");     // OpenAPI 기본 
            str.Append("?key=c71886bea109143f47d70cdb9dd40d69");   // 최초의 파라미터값은 '?', 다음부터는 '&'
            str.Append($"&movieNm={HttpUtility.UrlEncode(TxtSearchItem.Text)}");          // 검색어
            str.Append("&itemPerPage=10");                         // 읽어 올 데이터 수
            str.Append("&curPage=1");                              // 페이지 번호


            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("movie");           
            DgvSearchItems.Rows.Clear();

            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(    
                                            item["movieCd"].InnerText,                                                  // 영화코드
                                            item["movieNm"].InnerText,                                                  // 영화명 국문
                                            item["movieNmEn"].InnerText,                                                // 영화명 영문
                                            item["prdtYear"] == null ? string.Empty : item["prdtYear"].InnerText,       // 제작연도
                                            item["openDt"] == null ? string.Empty : item["openDt"].InnerText,           // 개봉연도
                                            item["typeNm"] == null ? string.Empty : item["typeNm"].InnerText,           // 영화유형
                                            item["prdtStatNm"] == null ? string.Empty : item["prdtStatNm"].InnerText,   // 제작상태
                                            item["nationAlt"] == null ? string.Empty : item["nationAlt"].InnerText,     // 제작국가
                                            item["genreAlt"] == null ? string.Empty : item["genreAlt"].InnerText,       // 영화장르
                                            item["directors"] == null ? string.Empty : item["directors"].InnerText,     // 영화감독
                                            item["companys"] == null ? string.Empty : item["companys"].InnerText        // 영화제작사
                                            //item["directors"] == null ? string.Empty : item["directors"].InnerText,   // 영화감독명
                                            //item["companyCd"] == null ? string.Empty : item["companyCd"].InnerText,   // 제작사코드
                                            //item["companys"] == null ? string.Empty : item["companys"].InnerText      // 제작사명
                                            );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"에러 발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSearch_Click(sender, new EventArgs());
            }
        }

        private void MtlBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm main = new MainForm();
            main.Location = this.Location;
            main.ShowDialog();

            this.Close();
        }
    }
}
