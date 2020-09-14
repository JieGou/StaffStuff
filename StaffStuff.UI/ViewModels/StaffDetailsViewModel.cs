using Prism.Commands;
using Prism.Regions;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.ViewModels
{
    /// <summary>
    /// 员工细节ViewModel
    /// </summary>
    public class StaffDetailsViewModel : ViewModelBase
    {
        /// <summary>
        /// 员工
        /// </summary>
        private Employee _employee;

        /// <summary>
        /// 员工
        /// </summary>
        public Employee Employee
        {
            get => _employee;
            set => SetProperty(ref _employee, value);
        }

        /// <summary>
        /// 导航的日志
        /// </summary>
        /// <remarks>
        /// 供区域导航到当前，后退和前进
        /// </remarks>
        private IRegionNavigationJournal _journal;

        /// <summary>
        /// 返回命令
        /// </summary>
        public DelegateCommand GoBackCommand { get; }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="regionManager"></param>
        public StaffDetailsViewModel(IRegionManager regionManager) : base(regionManager)
        {
            GoBackCommand = new DelegateCommand(GoBack);
        }

        /// <summary>
        /// 执行返回命令
        /// </summary>
        private void GoBack() => _journal.GoBack();

        /// <summary>
        /// 导航到
        /// </summary>
        /// <param name="navigationContext"></param>
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            this.Employee = navigationContext.Parameters[nameof(Employee)] as Employee;
            _journal = navigationContext.NavigationService.Journal;
        }
    }
}