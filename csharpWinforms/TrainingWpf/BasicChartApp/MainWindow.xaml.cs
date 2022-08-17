using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace BasicChartApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public ChartValues<double> LineValues { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializeChartData();
        }

        private void InitializeChartData()
        {
            LineValues = new ChartValues<double> { 3, 5, 6.7, 12.4, 0, 7, 9, 4.5 };
            DataContext = this;
        }
    }
}
