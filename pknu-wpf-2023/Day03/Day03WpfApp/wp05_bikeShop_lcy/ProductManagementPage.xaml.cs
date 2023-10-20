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
using wp05_bikeShop.Logics;

namespace wp05_bikeShop
{
    /// <summary>
    /// ProductManagementPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductManagementPage : Page
    {
        ProductsFactory factory = new ProductsFactory();


        public ProductManagementPage()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DgrProducts.ItemsSource = factory.FindProducts(TxtSearch.Text);
        }
    }
}
