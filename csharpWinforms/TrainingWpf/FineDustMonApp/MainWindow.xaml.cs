using MahApps.Metro.Controls;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace FineDustMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly string excelPath = $@"{AppDomain.CurrentDomain.BaseDirectory}busan_station_list.xls";
                
        private string openApiUrl = "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?" +
                                    "serviceKey=JzmUY2JqiPqaZHmZ7VDke8wMFu3m%2FCXZSUCawmglK99g1cw5ytYYWZ%2F4VmiJz2Wn5MB1aBEA7N0YlXlJz%2B%2FK8A%3D%3D&" +
                                    "returnType=xml&" +
                                    "numOfRows=100&" +
                                    "pageNo=1&" +
                                    "dataTerm=DAILY&" +
                                    "ver=1.0&" +
                                    "stationName=";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 엑셀파일에서 측정소 가져오기
            IWorkbook wb = null;
            ISheet sh = null;

            using (FileStream fs = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
            {
                wb = new HSSFWorkbook(fs);
            }

            List<string> lstLabs = new List<string>();

            sh = wb.GetSheetAt(0); // sheet1 
            int rowCount = sh.LastRowNum;

            try
            {
                for (int r = 0; r < rowCount; r++)
                {
                    if (r == 0) continue;

                    lstLabs.Add(sh.GetRow(r).Cells[1].ToString());
                }
            }
            catch (Exception ex)
            {
            }            

            Debug.WriteLine(lstLabs.Count);
            CboStations.ItemsSource = lstLabs;
        }        

        private void CboStations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstResult = new List<FineDustInfo>();

            if (CboStations.SelectedItem != null)
            {
                openApiUrl = openApiUrl.Substring(0, openApiUrl.LastIndexOf("=") + 1) + CboStations.SelectedItem.ToString();
                XmlDocument xml = new XmlDocument();
                xml.Load(openApiUrl);
                // OpenAPI 결과XML파일 원하는 경로까지 읽어오기
                XmlNodeList xnList = xml.SelectNodes("/response/body/items/item"); 

                foreach (XmlNode item in xnList)
                {
                    // Debug.WriteLine($"dateTime : {item["dataTime"].InnerText}");
                    lstResult.Add(new FineDustInfo() { 
                        DataTime = item["dataTime"].InnerText,
                        Khai = item["khaiValue"].InnerText,
                        SO2 = item["so2Value"].InnerText,
                        CO = item["coValue"].InnerText,
                        PM10 = item["pm10Value"].InnerText,
                        PM25 = item["pm25Value"].InnerText,
                        NO2 = item["no2Value"].InnerText,
                        O3 = item["o3Value"].InnerText,
                    });
                }
            }
            DgrFineDustInfos.ItemsSource = lstResult;
        }
        private List<FineDustInfo> lstResult;
    }

    public class FineDustInfo {
        public string DataTime { get; set; }
        public string Khai { get; set; }
        public string SO2 { get; set; }
        public string CO { get; set; }
        public string NO2 { get; set; }
        public string O3 { get; set; }
        public string PM10 { get; set; }
        public string PM25 { get; set; }
    }
}
