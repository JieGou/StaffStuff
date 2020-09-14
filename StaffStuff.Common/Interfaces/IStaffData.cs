using System.Collections.Generic;
using StaffStuff.Common.Models;

namespace StaffStuff.Common.Interfaces
{
    /// <summary>
    /// 员工数据接口
    /// </summary>
    public interface IStaffData
    {
        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();
    }
}