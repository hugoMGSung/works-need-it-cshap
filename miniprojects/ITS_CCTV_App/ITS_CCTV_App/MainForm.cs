using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ITS_CCTV_App
{
    public partial class MainForm : Form
    {
        private string ApiUrl = "https://openapi.its.go.kr:9443/cctvInfo";
        private string MyKey = "발급키";
        private string CamType = "ex"; // ex:고속도로 its:국도 동적 구분할 것
        private string StreamType = "1"; //(1: 실시간 스트리밍(HLS) / 2: 동영상 파일 / 3: 정지 영상)
        private string GetType = "json"; // or xml
        private StringBuilder ApiParams;

        private BackgroundWorker Worker = null;
        private LoadingForm loading = null;
        List<CctvData> exCctvs;
        List<CctvData> itsCctvs;

        public MainForm()
        {
            InitializeComponent();
            InitBackgroundWorker();

            Worker.RunWorkerAsync();
        }

        private void InitBackgroundWorker()
        {
            Worker = new BackgroundWorker();
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = false;
            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loading.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 스레드로 OpenAPI 실행하기(고속도로)
            InitApiParams("ex");
            string wbRequestResult = CallWebRequest();
            var r2 = JObject.Parse(wbRequestResult);
            var exRaw = r2.SelectToken("response.data") as JArray;
            exCctvs = JsonConvert.DeserializeObject<List<CctvData>>(exRaw.ToString());
            exCctvs.Insert(0, new CctvData { CctvName = "고속도로CCTV 선택" });

            if (LbxExCctv.InvokeRequired) 
                LbxExCctv.DataSource = exCctvs;

            // 스레드 내에서 국도 OpenApi 실행
            InitApiParams("its");
            wbRequestResult = CallWebRequest();
            r2 = JObject.Parse(wbRequestResult);
            exRaw = r2.SelectToken("response.data") as JArray;
            itsCctvs = JsonConvert.DeserializeObject<List<CctvData>>(exRaw.ToString());
            itsCctvs.Insert(0, new CctvData { CctvName = "국도CCTV 선택" });

            if (LbxItsCctv.InvokeRequired)
                LbxItsCctv.DataSource = itsCctvs;

            /*if (richTextBox1.InvokeRequired)
            {
                // 관련 정보 메모리에 로드
                richTextBox1.Text = wbRequestResult;
            }*/
            
            Worker.ReportProgress(100);
        }

        /// <summary>
        /// apiKey	string	공개키
        /// type string 도로 유형(ex: 고속도로 / its: 국도)
        /// cctvType string CCTV 유형(1: 실시간 스트리밍(HLS) / 2: 동영상 파일 / 3: 정지 영상)
        /// minX double 최소 경도 영역
        /// maxX double 최대 경도 영역
        /// minY double 최소 위도 영역
        /// maxY double 최대 위도 영역
        /// getType string 출력 결과 형식(xml, json / 기본: xml)
        /// </summary>
        private void InitApiParams(string type)
        {
            CamType = type;
            ApiParams = new StringBuilder();
            ApiParams.Append($"?apiKey={MyKey}");
            ApiParams.Append($"&type={CamType}");
            ApiParams.Append($"&cctvType={StreamType}");
            ApiParams.Append("&minX=126.000000"); 
            ApiParams.Append("&maxX=129.660000");
            ApiParams.Append("&minY=33.100000");
            ApiParams.Append("&maxY=39.660000");
            ApiParams.Append($"&getType={GetType}");
        }

        public string CallWebRequest()
        {
            string responseFromServer = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(ApiUrl + ApiParams.ToString());
                request.Method = "GET";
                request.ContentType = "application/json";

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    responseFromServer = reader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return responseFromServer;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            loading = new LoadingForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

#if DEBUG
#else
            loading.Show();     
#endif
        }

        private void LbxExCctv_SelectedIndexChanged(object sender, EventArgs e)
        {
            VlcCctv.Stop();
            if (LbxExCctv.SelectedIndex > 0)
            {
                LbxItsCctv.SelectedIndex = 0;
                // LbxExCctv에 선택된 값의 CCTV URL을 위에 표시
                TxtCctvUrl.Text = (LbxExCctv.SelectedItem as CctvData).CctvUrl;
                VlcCctv.Play(new Uri(TxtCctvUrl.Text));
            }
        }

        private void LbxItsCctv_SelectedIndexChanged(object sender, EventArgs e)
        {
            VlcCctv.Stop();
            if (LbxItsCctv.SelectedIndex > 0)
            {
                LbxExCctv.SelectedIndex = 0;
                // LbxItsCctv 선택된 값의 CCTV URL을 위에 표시
                TxtCctvUrl.Text = (LbxItsCctv.SelectedItem as CctvData).CctvUrl;
                VlcCctv.Play(new Uri(TxtCctvUrl.Text));
            }
        }

        private void VlcCctv_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }

        private void TxtExSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var search = TxtExSearch.Text.Trim();
                if (string.IsNullOrEmpty(search))
                {
                    LbxExCctv.DataSource = exCctvs;
                }
                else
                {
                    var items = (from a in exCctvs
                                 where a.CctvName.Contains(search)
                                 select a).ToList();
                    items.Insert(0, new CctvData { CctvName = "고속도로CCTV 선택" });
                    LbxExCctv.DataSource = items;
                }
            }
        }

        private void TxtItsSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var search = TxtItsSearch.Text.Trim();
                if (string.IsNullOrEmpty(search))
                {
                    LbxItsCctv.DataSource = itsCctvs;
                }
                else
                {
                    var items = (from a in itsCctvs
                                 where a.CctvName.Contains(search)
                                 select a).ToList();
                    items.Insert(0, new CctvData { CctvName = "국도CCTV 선택" });
                    LbxItsCctv.DataSource = items;
                }
            }
        }
    }
}
