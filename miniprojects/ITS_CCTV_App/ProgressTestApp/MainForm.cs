using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressIndicator.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            progressIndicator.AnimationSpeed = 75;
            progressIndicator.CircleSize = 0.7f;
            progressIndicator.NumberOfCircles = 13;
            progressIndicator.NumberOfVisibleCircles = 10;
            progressIndicator.Rotation = ProgressControls.RotationType.Clockwise;
            //progressIndicator.AutoStart = true;
            progressIndicator.Text = "Processing";
        }
    }
}
