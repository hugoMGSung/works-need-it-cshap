using Modules;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using TutorialPrismApp.Core;
using TutorialPrismApp.Prisms;
using TutorialPrismApp.ViewModels;
using TutorialPrismApp.Views;

namespace TutorialPrismApp
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Modules.ModulesLoader>();
        }

        //protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        //{
        //    base.ConfigureRegionAdapterMappings(regionAdapterMappings);
        //    regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
        //}

        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new ConfigurationModuleCatalog();
        //}

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    //moduleCatalog.AddModule<Modules.ModulesLoader>();
        //    var subModuleType = typeof(ModulesLoader);
        //    moduleCatalog.AddModule(new ModuleInfo()
        //    {
        //        ModuleName = subModuleType.Name,
        //        ModuleType = subModuleType.AssemblyQualifiedName,
        //        InitializationMode = InitializationMode.OnDemand
        //    });
        //}

        //protected override void ConfigureViewModelLocator()
        //{
        //    base.ConfigureViewModelLocator();

        //    ViewModelLocationProvider.Register<MainView, MainViewModel>();
        //}
    }
}
