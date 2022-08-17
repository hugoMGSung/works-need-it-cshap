using Caliburn.Micro;
using SecondCaliburnApp.ViewModels;
using System.Windows;

namespace SecondCaliburnApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>(); // object -> ViewModel 
        }
    }
}
