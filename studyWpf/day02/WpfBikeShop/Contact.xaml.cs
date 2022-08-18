using System.Windows;
using System.Windows.Controls;

namespace WpfBikeShop
{
    /// <summary>
    /// Contact.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Contact : Page
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hell, World!!");
        }
    }
}
