using LeftModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace LeftModule
{
    public class LeftModuleLoader : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("LeftRegion", typeof(MessageView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) { }
    }
}
