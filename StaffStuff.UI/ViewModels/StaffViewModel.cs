using System.Collections.Generic;
using Prism.Commands;
using Prism.Regions;
using StaffStuff.Common;
using StaffStuff.Common.Interfaces;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.ViewModels
{
    /// <summary>
    /// 员工ViewModel
    /// </summary>
    public class StaffViewModel : ViewModelBase
    {
        /// <summary>
        /// 员工列表
        /// </summary>
        private List<Employee> _employees;

        /// <summary>
        /// 员工列表
        /// </summary>
        public List<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }

        /// <summary>
        /// 查看员工详细信息命令
        /// </summary>
        public DelegateCommand<Employee> EmployeeDetailsCommand { get; }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="staffData">员工数据</param>
        /// <param name="regionManager">区域管理者</param>
        public StaffViewModel(IStaffData staffData, IRegionManager regionManager) : base(regionManager)
        {
            Employees = staffData.GetEmployees();
            EmployeeDetailsCommand = new DelegateCommand<Employee>(StaffDetails);
        }

        /// <summary>
        /// 执行命令 显示员工细节信息
        /// </summary>
        /// <param name="employee"></param>
        private void StaffDetails(Employee employee)
        {
            var parameters = new NavigationParameters
            {
                {nameof(Employee), employee}
            };

            RegionManager.RequestNavigate(RegionNames.ContentRegion, "StaffDetailsView", parameters);
        }
    }
}