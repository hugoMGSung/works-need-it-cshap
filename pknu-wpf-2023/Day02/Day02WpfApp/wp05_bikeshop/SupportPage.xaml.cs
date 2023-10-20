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
using wp05_bikeshop.Logics;

namespace wp05_bikeshop
{
    /// <summary>
    /// SupportPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SupportPage : Page
    {
        Car myCar = null;

        public SupportPage()
        {
            InitializeComponent();
            InitCar();
        }

        private void InitCar()
        {
            // 일반적인 C#에서 클래스 객체 인스턴스 사용방법 동일
            myCar = new Car();
            myCar.Names = "아이오닉";
            myCar.Colors = Colors.White;
            myCar.Speed = 220;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //TxtSample.Text = myCar.Speed.ToString(); // 전통적인 윈폼 방식
        }

        //private void SldValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    PgbValue.Value = SldValue.Value;
        //    LblValue.Content = SldValue.Value;
        //}
    }
}
