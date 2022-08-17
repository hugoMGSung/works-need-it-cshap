using Caliburn.Micro;
using System.Windows;
using System.Windows.Media;

namespace StartCaliburnApp.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IHaveDisplayName
    {
        public string DisplayName { get; set; }

        string name;
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

        public ShellViewModel()
        {
            DisplayName = "Basic Caliburn App";
        }

        public bool CanSayHello
        {
            get => !string.IsNullOrEmpty(Name);
        }

        public void SayHello()
        {
            MessageBox.Show($"Hello {Name}");
        }
    }
}
