using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Test.AnhPhuong_Test.Test_EventManagement
{
    /// <summary>
    /// Summary description for TestFunction
    /// </summary>
    [TestClass]
    public class TestFunction
    {
        private PdbEvent event1;
        [TestInitialize]
        public void setUp()
        {
            event1 = new PdbEvent();
            event1.ID_Event = Guid.NewGuid();
            event1.EventName = "Đi net";
            event1.ExpectedCost = 500000;
            event1.CostsAwarded = 400000;
            event1.ActualCosts = 300000;
            event1.Scale = "3";
            event1.Location = "Phan xích long";
            event1.DateStart = DateTime.Now;
            event1.DateEnd = DateTime.Now;
            event1.TravelBy = "xe máy";
            event1.Money_Staff_Pay = 20000;
            event1.EventContent = "abcd";
        }

        [TestMethod]
        public void TestEvent()
        {
            bool check = new Events(new EmployeeManagementDBContext()) { }.Add(event1);
            Assert.AreNotEqual(check, false);
        }
    }
}
