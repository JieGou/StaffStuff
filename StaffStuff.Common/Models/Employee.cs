namespace StaffStuff.Common.Models
{
    /// <summary>
    /// 员工类
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 姓
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 关于
        /// </summary>
        public string About { get; set; }
    }
}