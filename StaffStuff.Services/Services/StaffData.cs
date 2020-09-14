using System.Collections.Generic;
using Bogus;
using StaffStuff.Common.Interfaces;
using StaffStuff.Common.Models;

namespace StaffStuff.Services.Services
{
    /// <summary>
    /// 员工数据
    /// </summary>
    public class StaffData : IStaffData
    {
        /// <summary>
        /// 获取模拟员工列表
        /// </summary>
        /// <remarks>
        /// 语言代号从<a href="https://github.com/bchavez/Bogus ">Bogus</a>获取
        /// </remarks>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            //明确指定中文
            var faker = new Faker<Employee>("zh_CN")
                .RuleFor(e => e.FirstName, (f, e) => f.Name.FirstName())
                .RuleFor(e => e.LastName, (f, e) => f.Name.LastName())
                .RuleFor(e => e.Avatar, f => f.Internet.Avatar())
                .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
                .RuleFor(e => e.JobTitle, f => f.Name.JobTitle())
                .RuleFor(e => e.About, f => f.Lorem.Paragraph(10));

            return faker.Generate(5);
        }
    }
}