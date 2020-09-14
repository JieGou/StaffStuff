using StaffStuff.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using StaffStuff.Common;

namespace StaffStuff.UI
{
    public class UIModule : IModule
    {
        /// <summary>
        /// 当模块初始化完成时执行
        /// </summary>
        /// <param name="containerProvider"></param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(StaffView));
        }

        /// <summary>
        /// 注册类型
        /// </summary>
        /// <param name="containerRegistry"></param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //两个视图都添加到导航中

            //注册员工视图
            containerRegistry.RegisterForNavigation<StaffView>();

            //注册员工详细视图
            containerRegistry.RegisterForNavigation<StaffDetailsView>();
        }
    }
}