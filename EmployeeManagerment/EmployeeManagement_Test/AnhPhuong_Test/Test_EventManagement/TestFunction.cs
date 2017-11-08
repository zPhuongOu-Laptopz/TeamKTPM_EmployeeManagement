using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;
namespace EmployeeManagement_Test.AnhPhuong_Test.Test_EventManagement
{
    [TestClass]
    public class TestFuntion
    {
        private PdbBonusSalary TestSalary;
        [TestInitialize]
        public void Setup()
        {
            TestSalary = new PdbBonusSalary();
            TestSalary.IDBS = Guid.NewGuid();
            TestSalary.IDStaff = new Guid("5a1c6fe2-c0b3-4939-ab6f-0b6e0b534775");
            TestSalary.MoneyBonus = 123;
            TestSalary.DayBonus = DateTime.Now;
            TestSalary.ReasonBonus = "i don't know";
            TestSalary.MonthBonus = "march";
            TestSalary.YearBonus = "2017";

        }
        [TestMethod]
        public void TestSalaryAdd()
        {
            bool check = new Salary(new EmployeeManagementDBContext()) { }.Add(TestSalary);
            Assert.AreNotEqual(check, false);
        }
    }
}
