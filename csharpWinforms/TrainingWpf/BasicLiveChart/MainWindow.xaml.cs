using LiveCharts;
using System.Windows;

namespace BasicLiveChart
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitChart();
        }

        public ChartValues<float> Values { get; set; }

        private void InitChart()
        {
            Values = new ChartValues<float> { 3, 4, 6, 3, 2, 6 };
            DataContext = this;
        }
    }
}
