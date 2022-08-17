using System;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualSize.Text = string.Empty;
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum porro ullam magni amet incidunt eos numquam accusamus consequuntur reiciendis sapiente, corrupti iusto obcaecati unde ipsum, expedita illum dolor, quam velit.";
            string sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequatur qui eum rem assumenda quia, ut repudiandae deleniti laborum nemo veniam optio quisquam earum aperiam esse soluta eligendi unde dolore impedit.";

            LblAutoSize.Text = sample1;
            LblManualSize.Text = sample2;
        }
    }
}
