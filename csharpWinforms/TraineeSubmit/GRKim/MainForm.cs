using MetroFramework.Controls;
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
using MetroFramework;

namespace _01_1.TestOpenAPI
{

	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			InitializeComponent();

			// 폼을 화면 정중앙에 띄우기
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2
				, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
		}

		private void MtlSearchItem_Click(object sender, EventArgs e)
		{
			WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
			XmlDocument doc = new XmlDocument();

			// 콤보박스 아이템 선택 시
			string cby = CbbYear.SelectedItem as string;
			string cbsm = CbbSMonth.SelectedItem as string;
			string cbem = CbbEMonth.SelectedItem as string;

			if(string.IsNullOrEmpty(cby) || string.IsNullOrEmpty(cbsm) || string.IsNullOrEmpty(cbem))
			{
				MetroMessageBox.Show(this, "검색을 원하는 년/월을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if(CbbSMonth.SelectedIndex > CbbEMonth.SelectedIndex)
			{
				MetroMessageBox.Show(this, "잘못된 형식입니다. 시작월과 끝월을 확인해주세요", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(TxtSerachItem.Text))
			{
				MetroMessageBox.Show(this, "검색을 원하는 국가코드를 선택(입력)하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			StringBuilder str = new StringBuilder();
			str.Append("http://openapi.customs.go.kr/openapi/service/newTradestatistics/getnationtradeList");                              // Open API 기본 URL
			str.Append("?serviceKey=YQl80LabfUEqstQzXuRsm8e1y4l2GLxdDuRImC44RnQWAkaBYaS8R0dbQQ%2B0DiKFPdue3Nc4M%2F4BqI%2FLt6srOA%3D%3D");  // 인증키
			str.Append($"&searchBgnDe={cby}{cbsm}");            // 시작 년도/월      
			str.Append($"&searchEndDe={cby}{cbem}");            // 끝 년도/월    
			str.Append($"&searchStatCd={TxtSerachItem.Text}");  // 국가코드    
			str.Append("&numOfRows=50");						// 페이지당 출력 건수
			str.Append("&pageNo=1");							// 페이지 번호

			string xml = wc.DownloadString(str.ToString());
			doc.LoadXml(xml);

			XmlElement root = doc.DocumentElement;
			XmlNodeList items = doc.GetElementsByTagName("item");

			TblResult.Rows.Clear();

			foreach (XmlNode item in items)
			{
				TblResult.Rows.Add(item["year"]?.InnerText,
					item["statCdCntnKor1"]?.InnerText,
					item["statCd"]?.InnerText,
					item["expCnt"]?.InnerText,
					item["expDlr"]?.InnerText,
					item["impCnt"]?.InnerText,
					item["impDlr"]?.InnerText,
					item["balPayments"]?.InnerText,
					item["totalCount"]?.InnerText);               
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// 열을 선택
			CountryCodeList.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;

			// 행 추가
			string[] Rrow1 = { "AU", "BR", "CH", "CL", "CN", "DE", "ES", "FR", "GB", "HK", "BT", "CG", "TW", "US" };
			string[] Rrow2 = { "BE", "CA", "GU", "CU", "EG", "FI", "FJ", "GH", "GN", "IR", "KE", "MT", "NP", "PE" };
			CountryCodeList.Rows.Add(Rrow1);
			dataGridView1.Rows.Add(Rrow2);
		}

		private void TxtSerachItem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				MtlSearchItem_Click(sender, new EventArgs());
		}


		private void CountryCodeList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn data = CountryCodeList.Columns[e.ColumnIndex];

			int RIndex = data.Index;

			DataGridViewRow rowdata = CountryCodeList.Rows[0];
			TxtSerachItem.Text = rowdata.Cells[RIndex].Value.ToString();
		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn data = dataGridView1.Columns[e.ColumnIndex];

			int RIndex = data.Index;

			DataGridViewRow rowdata = dataGridView1.Rows[0];
			TxtSerachItem.Text = rowdata.Cells[RIndex].Value.ToString();
		}
	}
}
