using System.Windows;

using WpfExamples;

namespace RealtimeDemo
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    [Example("Plotting a curve that updates automatically.")]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            this.DataContext = new MainViewModel();
        }
    }
}
