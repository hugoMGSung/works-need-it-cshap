using Caliburn.Micro;
using System.Windows;

namespace SecondCaliburnApp.ViewModels
{
    public class FirstChildViewModel : Screen
    {
        public void FirstClicked()
        {
            MessageBox.Show("Hello World!!");
        }
    }
}
