using MahApps.Metro.Controls;
using MvvmApp.ViewModels;

namespace MvvmApp.Views
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ShellView : MetroWindow
    {
        public ShellView()
        {
            InitializeComponent();
            this.DataContext = new ShellViewModel();
        }
    }
}
