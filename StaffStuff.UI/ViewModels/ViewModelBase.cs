using Prism.Mvvm;
using Prism.Regions;

namespace StaffStuff.UI.ViewModels
{
    /// <summary>
    /// ViewModel基类
    /// </summary>
    public class ViewModelBase : BindableBase, INavigationAware
    {
        protected IRegionManager RegionManager { get; }

        public ViewModelBase(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}