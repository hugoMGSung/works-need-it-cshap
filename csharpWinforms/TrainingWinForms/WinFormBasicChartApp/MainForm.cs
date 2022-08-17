using MetroFramework.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System;

namespace WinFormBasicChartApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            // 차트에 표시 할 항목 모음 정의
            //SeriesCollection piechartData = new SeriesCollection
            //{
            //    new PieSeries
            //    { 
            //        Title = "First Item",
            //        Values = new ChartValues<double> {25},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries
            //    {
            //        Title = "Second Item",
            //        Values = new ChartValues<double> {25},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries
            //    {
            //        Title = "Third Item",
            //        Values = new ChartValues<double> {25},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    }
            //};

            //// 컬렉션의 add 메서드를 사용하여 새 항목을 동적으로 추가
            //// 정적이 아닌 데이터를 동적으로 정의 할 때 유용
            //piechartData.Add(
            //    new PieSeries
            //    {
            //        Title = "Fourth Item",
            //        Values = new ChartValues<double> { 25 },
            //        DataLabels = true,
            //        LabelPoint = labelPoint,
            //        Fill = System.Windows.Media.Brushes.Gray
            //    }
            //);
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "USA",
                    Values = new ChartValues<double> {6450},
                    DataLabels = true,
                    LabelPoint = labelPoint,

                },
                new PieSeries
                {
                    Title = "Russia",
                    Values = new ChartValues<double> {6850},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "United Kingdom",
                    Values = new ChartValues<double> {215},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "France",
                    Values = new ChartValues<double> {300},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "China",
                    Values = new ChartValues<double> {280},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            // Set the legend location to appear in the bottom of the chart
            pieChart1.LegendLocation = LegendLocation.Bottom;

            // 파이차트에 표시 할 값 모음 정의
            //pieChart1.Series = piechartData;

            //// 범례 위치를 차트 오른쪽에 표시하도록 설정
            //pieChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
