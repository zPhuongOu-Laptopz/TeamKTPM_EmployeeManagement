using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Test.Quang_Test.Test_EventManagement
{
   
    [TestClass]
    public class TestFunctionAccount
    {
        private PdbAccount account;
        [TestInitialize]
        public void SetUp()
        {
            account = new PdbAccount();
            account.AccountName = "test1";
            account.AccountPassword = "test";
            account.AccountLevel = "NS";
            account.IDAccount = Guid.NewGuid();
            account.IDStaff = new Guid("5a1c6fe2-c0b3-4939-ab6f-0b6e0b534775");
            account.isActive = true;
        }

        [TestMethod]
        public void CreateAccount()
        {
            bool checkadd = new Accounts(new EmployeeManagementDBContext()) { }.Create(account);
            Assert.AreNotEqual(checkadd, false);
        }
        [TestMethod]
        public void UpdateAccount()
        {
            account = new PdbAccount();
            account.AccountName = "testupdate";
            account.AccountPassword = "testupdate";
            account.AccountLevel = "Bao Ve";
            account.IDAccount = new Guid("6378A0EC-BD76-4230-88D5-6DBCB441A9E7");
            account.IDStaff = new Guid("B5DAF9C8-AC90-49CA-A742-B419AFAB01B5");
            account.isActive = true;
            bool checkupdate = new Accounts(new EmployeeManagementDBContext()) { }.Update(account);
            Assert.AreNotEqual(checkupdate, false);
        }
        [TestMethod]
        public void DeleteAccount()
        {
            account = new PdbAccount();
            account.AccountName = "testdelete";
            account.AccountPassword = "testdelete";
            account.AccountLevel = "NS";
            account.IDAccount = new Guid("A544D2F1-E89A-4AB6-BE88-FFFB5165E38F");
            account.IDStaff = new Guid("B5DAF9C8-AC90-49CA-A742-B419AFAB01B5");
            account.isActive = true;
            bool checkdetele = new Accounts(new EmployeeManagementDBContext()) { }.Delete(account.IDAccount);
            Assert.AreNotEqual(checkdetele, false);
        }
    }
}
