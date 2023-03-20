using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Windows;
using WpfSmartHomeMonitoringApp.ViewModels;

namespace WpfSmartHomeMonitoringApp
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container; // 다이얼로그, 팝업, 기타 설정

        public Bootstrapper()
        {
            Initialize(); // !
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        /// <summary>
        /// Caliburn MVVM 초기 설정
        /// </summary>
        protected override void Configure()
        {
            container = new SimpleContainer();
            container.Singleton<IWindowManager, WindowManager>();

            container.PerRequest<MainViewModel>();
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
