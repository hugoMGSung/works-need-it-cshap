using Caliburn.Micro;
using StartCaliburnApp.ViewModels;
using System.Windows;

namespace StartCaliburnApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // base.OnStartup(sender, e);
            DisplayRootViewFor<ButtonViewModel>();
        }
    }
}
