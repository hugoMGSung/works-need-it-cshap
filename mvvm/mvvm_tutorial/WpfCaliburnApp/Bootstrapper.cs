using Caliburn.Micro;
using System.Windows;
using WpfCaliburnApp.ViewModels;

namespace WpfCaliburnApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize(); // Caliburn.Micro 초기화(필수!!)
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // base.OnStartup(sender, e);
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
