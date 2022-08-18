using Caliburn.Micro;
using System.Windows;
using WpfCaliburnApp.ViewModels;

namespace WpfCaliburnApp
{
    /// <summary>
    /// 시작 윈도우 지정!! 
    /// </summary>
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
