using MetroFramework;
using System;
using System.Windows.Forms;

namespace ChartControlApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Using Chart Control";

            // 10명의 학생 랜덤점수 생성 및 차트 바인딩
            Random rand = new Random();
            chart1.Titles.Add("중간고사 성적");
            for (int i = 0; i < 10; i++)
            {
                int val = rand.Next(10, 100);
                chart1.Series["Score"].Points.Add(val);
                //chart1.Series["Score"].ToolTip = val.ToString();
            }
            chart1.Series["Score"].LegendText = "수학점수";
            chart1.Series["Score"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Score"].Points.Clear();
            MetroMessageBox.Show(this, "데이터를 지웠습니다", "처리",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
