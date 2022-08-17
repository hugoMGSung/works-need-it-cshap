﻿using Caliburn.Micro;
using Covid19MonitorApp.ViewModels;
using System.Windows;

namespace Covid19MonitorApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>(); // TODO Change
        }
    }
}
