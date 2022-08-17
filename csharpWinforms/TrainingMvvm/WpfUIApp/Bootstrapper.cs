using Caliburn.Micro;
using System.Windows;
using WpfUIApp.ViewModels;

namespace WpfUIApp
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
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
