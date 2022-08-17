using ListModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ListModule
{
    public class ModuleLoader : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(PersonListView));
            //regionManager.RegisterViewWithRegion("PersonDetailsRegion", typeof(PersonDetailView));
            regionManager.RequestNavigate("ContentRegion", "PersonListView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PersonListView>();
            containerRegistry.RegisterForNavigation<PersonDetailView>();
        }
    }
}
