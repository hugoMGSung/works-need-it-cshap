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

namespace wp05_bikeshop
{
    /// <summary>
    /// MenuPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void BtnMenuContact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ContactPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnMenuSupport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SupportPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TestPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnMenuProducts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProductPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
