using NavModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;

namespace NavModule
{
    public class ModuleLoader : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider) { }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AView>();
            containerRegistry.RegisterForNavigation<BView>();
        }
    }
}
