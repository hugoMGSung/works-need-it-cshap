using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace wp05_bikeShop.Logics
{

    internal class Car : Notifier               // 값이 바뀌는 걸 인지하여 처리하겠다
    {
        private string names;// 오토프로퍼티X
        public string Names
        { 
            get => names;

            // 프로퍼티 변경하는 것
            set
            {
                names = value;
                OnPropertyChanged("Names");     // Names 프로퍼티가 바뀌었어요!
            }
        }

        private double speed;
        public double Speed
        {
            get => speed;
            set
            {
                speed = value;
                OnPropertyChanged(nameof(Speed));// "Speed"
            }
        }


        //public string Names { get; set; }        // 오토 프로퍼티(매개변수 따로 안 만듦)
        //public double Speed { get; set; }
        public Color Colour { get; set; }
        public Human Driver { get; set; }   
    }
}
