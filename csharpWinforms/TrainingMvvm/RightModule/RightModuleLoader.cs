using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using RightModule.Views;

namespace RightModule
{
    public class RightModuleLoader : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("RightRegion", typeof(MessageList));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) { }
    }
}
