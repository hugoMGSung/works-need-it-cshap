using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace wp05_bikeShop.Logics
{
    internal class MyConverter : IValueConverter
    {
        // 대상에다 표현할 때 값을 변환 ((OneWay))
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return int.Parse(value.ToString()) + "km/h";
        }

        // 대상값이 바뀌어서 원본(소스)의 값을 변환, 표현 ((TwoWay))
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return int.Parse(value.ToString()) * 3; // Logics 네임스페이스에서 만들어진 클래스 바로 못 씀 
        }
    }
}
