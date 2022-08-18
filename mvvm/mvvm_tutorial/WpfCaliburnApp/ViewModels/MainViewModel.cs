using Caliburn.Micro;
using System.Windows;

namespace WpfCaliburnApp.ViewModels
{
    public class MainViewModel : PropertyChangedBase, IHaveDisplayName
    {
        public string DisplayName { get; set; }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public MainViewModel()
        {
            DisplayName = "Basic Caliburn.Micro App v1.0";
        }

        // x:Name SayHello
        public void SayHello()
        {
            MessageBox.Show($"Hello, {Name}");
        }

        // Can + x:Name
        public bool CanSayHello
        {
            get => !string.IsNullOrEmpty(Name);
        }
    }
}
