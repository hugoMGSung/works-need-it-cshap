using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace MyStockAdvisor.SubScreen
{
    public partial class WebScreen : MetroForm
    {
        public string ParentUrl { get; set; }

        WebClient client;

        public WebScreen()
        {
            InitializeComponent();
        }

        private void WebScreen_Load(object sender, EventArgs e)
        {
            // Common.ResizeImage(Common.LoadPicture(ParentUrl), pictureBox1, true);
            // 용량이 겁나 크다 안좋음
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Done!!");
            string fileName = ParentUrl.Substring(ParentUrl.LastIndexOf('=') + 1);
            pictureBox1.Load(Environment.CurrentDirectory + $@"\{fileName}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate () {
                PgbImageDownload.Value = e.ProgressPercentage;

                if (e.BytesReceived == e.TotalBytesToReceive)
                {
                    Client_DownloadFileCompleted(sender, null);
                }
            }));
        }

        #region 사용안함 - 나중에 참조

        private void BgwImageDown_DoWork(object sender, DoWorkEventArgs e)
        {
            // the URL to download the file from
            string sUrlToReadFileFrom = ParentUrl;
            // the path to write the file to
            string sFilePathToWriteFileTo = System.Environment.CurrentDirectory + $@"\{ParentUrl.Substring(ParentUrl.LastIndexOf('=') + 1)}";

            // first, we need to get the exact size (in bytes) of the file we are downloading
            Uri url = new Uri(sUrlToReadFileFrom);
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            response.Close();
            // gets the size of the file in bytes
            Int64 iSize = response.ContentLength;

            // keeps track of the total bytes downloaded so we can update the progress bar
            Int64 iRunningByteTotal = 0;

            // use the webclient object to download the file
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                // open the file at the remote URL for reading
                using (System.IO.Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                {
                    // using the FileStream object, we can write the downloaded bytes to the file system
                    using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        // loop the stream and get the file into the byte buffer
                        int iByteSize = 0;
                        byte[] byteBuffer = new byte[iSize];
                        while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                        {
                            // write the bytes to the file system at the file path specified
                            streamLocal.Write(byteBuffer, 0, iByteSize);
                            iRunningByteTotal += iByteSize;

                            // calculate the progress out of a base "100"
                            double dIndex = (double)(iRunningByteTotal);
                            double dTotal = (double)byteBuffer.Length;
                            double dProgressPercentage = (dIndex / dTotal);
                            int iProgressPercentage = (int)(dProgressPercentage * 100);

                            // update the progress bar
                            BgwImageDown.ReportProgress(iProgressPercentage);
                        }

                        // clean up the file stream
                        streamLocal.Close();
                    }

                    // close the connection to the remote server
                    streamRemote.Close();
                }
            }
        }

        private void BgwImageDown_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PgbImageDownload.Value = e.ProgressPercentage;
        }

        private void BgwImageDown_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Download Done!");
        }

        #endregion

        private void WebScreen_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Uri uri = new Uri(ParentUrl);
                string fileName = ParentUrl.Substring(ParentUrl.LastIndexOf('=') + 1);
                client.DownloadFileAsync(uri, Environment.CurrentDirectory + $@"\{fileName}");
            });
            thread.Start();
        }
    }
}
