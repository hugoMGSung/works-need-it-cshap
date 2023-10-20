using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace wp02_simplecontrols
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SldStep_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PgbStep.Value = (int)SldStep.Value;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            MediaPlayer.Source = new Uri(path + @"\Resources\earth.avi", UriKind.RelativeOrAbsolute);
            MediaPlayer.Play();
        }
    }
}
