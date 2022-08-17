using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace BackgroundWorkerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BgwTest.WorkerReportsProgress = true;
            BgwTest.WorkerSupportsCancellation = true;
        }

        private void BtnStartAsync_Click(object sender, EventArgs e)
        {
            if (BgwTest.IsBusy != true)
            {
                BgwTest.RunWorkerAsync();
            }
        }

        private void BtnCancelAsync_Click(object sender, EventArgs e)
        {
            if (BgwTest.WorkerSupportsCancellation == true)
            {
                BgwTest.CancelAsync();
            }
        }

        // 작업이 시작될때 다른 스레드에서 실행할 이벤트핸들러
        private void BgwTest_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            for (int i = 0; i < 10; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(200);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        // 작업자의 스레드에서 일부 진행되었음을 나타낼때 사용하는 이벤트핸들러
        private void BgwTest_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LblResult.Text = e.ProgressPercentage.ToString() + "%";
        }

        // 작업자가 완료(성공, 실패 또는 취소) 되었을때 발생하는 이벤트핸들러
        private void BgwTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                LblResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                LblResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
                LblResult.Text = "Done!";
            }
        }
    }
}
