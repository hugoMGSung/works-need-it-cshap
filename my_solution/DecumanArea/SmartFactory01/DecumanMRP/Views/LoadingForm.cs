using DecumanMRP.StaticInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecumanMRP.Views
{
    public partial class LoadingForm : Form
    {
        delegate void StringParameterDelegate(string Text);
        delegate void StringParameterWithStatusDelegate(string Text, TypeOfMessage tom);
        delegate void SplashShowCloseDelegate();

        bool CloseSplashScreenFlag = false;

        public LoadingForm()
        {
            InitializeComponent();

            this.LblLoadingMsg.Parent = this.pictureBox1;
            LblLoadingMsg.Text = "Wait";
            LblLoadingMsg.ForeColor = Color.Green;
        }

        public void ShowForm()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SplashShowCloseDelegate(ShowForm));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        public void CloseForm()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SplashShowCloseDelegate(CloseForm));
                return;
            }
            CloseSplashScreenFlag = true;
            this.Close();
        }

        public void UdpateStatusText(string Text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new StringParameterDelegate(UdpateStatusText), new object[] { Text });
                return;
            }
            LblLoadingMsg.ForeColor = Color.Green;
            LblLoadingMsg.Text = Text;
        }

        public void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new StringParameterWithStatusDelegate(UdpateStatusTextWithStatus), new object[] { Text, tom });
                return;
            }

            switch (tom)
            {
                case TypeOfMessage.Error:
                    LblLoadingMsg.ForeColor = Color.Red;
                    break;
                case TypeOfMessage.Warning:
                    LblLoadingMsg.ForeColor = Color.Yellow;
                    break;
                case TypeOfMessage.Success:
                    LblLoadingMsg.ForeColor = Color.Green;
                    break;
            }
            LblLoadingMsg.Text = Text;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }

        private void FormEffect(Form fm)
        {
            double[] opacity = new double[] { 0.1d, 0.3d, 0.7d, 0.8d, 0.9d, 1.0d };
            int cnt = 0;
            Timer tm = new Timer();
            {
                fm.RightToLeftLayout = false;
                fm.Opacity = 0d;
                tm.Interval = 70;   // 나타나는 속도를 조정함.          
                tm.Tick += delegate (object obj, EventArgs e)
                {
                    if ((cnt + 1 > opacity.Length) || fm == null)
                    {
                        tm.Stop();
                        tm.Dispose();
                        tm = null;
                        return;
                    }
                    else
                    {
                        fm.Opacity = opacity[cnt++];
                    }
                };
                tm.Start();
            }
        }
    }
}
