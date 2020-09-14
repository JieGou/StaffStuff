using System.Linq;
using Bogus;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.SampleData
{
    /// <summary>
    /// 员工细节示例ViewModel
    /// </summary>
    public class SampleStaffDetailsViewModel
    {
        /// <summary>
        /// 员工
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public SampleStaffDetailsViewModel()
        {
            //用默认的“ en”区域创建一个模拟数据
            var faker = new Faker<Employee>()
                .RuleFor(e => e.FirstName, (f, e) => f.Name.FirstName())
                .RuleFor(e => e.LastName, (f, e) => f.Name.LastName())
                .RuleFor(e => e.Avatar, f => f.Internet.Avatar())
                .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
                .RuleFor(e => e.JobTitle, f => f.Name.JobTitle())
                .RuleFor(e => e.About, f => f.Lorem.Paragraph(10));

            Employee = faker.Generate(1).Single();
        }
    }
}