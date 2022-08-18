using System.Windows.Media;

namespace WpfBikeShop
{
    public class Car : Notifier
    {
        private double speed;
        public double Speed { 
            get { return speed; }
            set { 
                speed = value;
                OnPropertyChanged("Speed");  // Speed 속성의 값이 변경되었습니다!! 
            } 
        }
        public Color Color { get; set; }
        public Human Driver { get; set; }

        public Car()
        {
        }
    }

    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
}