using MahApps.Metro.Controls;
using System.Windows;

namespace WpfMovieFinder.Views
{
    /// <summary>
    /// CustomPopupView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CustomPopupView : MetroWindow
    {
        public CustomPopupView(string message)
        {
            InitializeComponent();

            this.ReportMessage.Content = message;
        }

        private void CloseAccept_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
