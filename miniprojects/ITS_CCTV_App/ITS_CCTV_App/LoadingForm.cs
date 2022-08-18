using System;
using System.Windows.Forms;

namespace ITS_CCTV_App
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            Indicator.Start();
        }

    }
}
