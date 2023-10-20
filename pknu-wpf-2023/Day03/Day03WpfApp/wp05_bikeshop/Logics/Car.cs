using System.Windows.Media;

namespace wp05_bikeshop.Logics
{
    internal class Car : Notifier // 값이 바뀌는 걸 인지하여서 처리하겠다
    {
        private string names;
        public string Names { 
            get => names;
            // 프로퍼티를 변경하는 것
            set
            {
                names = value;
                OnPropertyChanged("Names"); // Names 프로퍼티가 바꼈어요!!
            }
        }
        private double speed;
        public double Speed {
            get => speed; 
            set
            {
                speed = value;
                OnPropertyChanged(nameof(Speed)); // == "Speed"
            }
        }
        public Color Colorz { get; set; }
        public Human Driver { get; set; } // Auto Property
    }
}
