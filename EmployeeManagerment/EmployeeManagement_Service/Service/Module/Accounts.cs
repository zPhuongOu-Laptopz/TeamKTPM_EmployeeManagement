using System;
using System.Collections.Generic;
using EmployeeManagement_Service.ModelDBContext;
using System.Linq;

namespace EmployeeManagement_Service.Service.Module
{
    public class Accounts
    {
        private readonly EmployeeManagementDBContext _context;

        public Accounts(EmployeeManagementDBContext context)
        {
            this._context = context;
        }
        
        public IEnumerable<PdbAccount> AccountAll()
        {
            return this._context.PdbAccounts;
        }

        public bool Create(PdbAccount account)
        {
            this._context.PdbAccounts.Add(account);
            this._context.Entry(account).State = System.Data.Entity.EntityState.Added;
            return this._context.SaveChanges() == 1;
        }

        public bool Update(PdbAccount account)
        {
            this._context.PdbAccounts.Attach(account);
            this._context.Entry(account).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbAccount account = _context.PdbAccounts.SingleOrDefault(admin => admin.IDAccount == id);
            _context.PdbAccounts.DefaultIfEmpty(account);
            _context.Entry(account).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbAccount GetAccountwithID(Guid id)
        {
            return _context.PdbAccounts.SingleOrDefault(ac => ac.IDAccount == id);
        }

        public PdbAccount GetAccountwithUP(string username, string password)
        {
            return _context.PdbAccounts.SingleOrDefault(ac => ac.AccountName == username || ac.AccountPassword == password );
        }

        public PdbAccount GetAccountwithUPD(string username, string password, string department)
        {
            PdbAccount ac = GetAccountwithUP(username, password);
            PdbStaff staff = this._context.PdbStaffs.SingleOrDefault(st => st.ID_Staff == ac.IDStaff);
            if (staff.Department == department)
            {
                return ac;
            }
            return null;
        }
    }
}

//namespace LibraryDBContext.Repositories
//{
//    public class Admins : IAdmins
//    {
//        private readonly AdminsDBContext _context;

//        public Admins(AdminsDBContext context)
//        {
//            this._context = context;
//        }

//        public IEnumerable<Admin> AdminsAll()
//        {
//            return _context.Admins;
//        }

//        public bool Add(Admin ad)
//        {
//            _context.Admins.Add(ad);
//            _context.Entry(ad).State = System.Data.Entity.EntityState.Added;
//            return _context.SaveChanges() == 1;
//        }

//        public bool Edit(Admin ad)
//        {
//            _context.Admins.Attach(ad);
//            _context.Entry(ad).State = System.Data.Entity.EntityState.Modified;
//            return _context.SaveChanges() == 1;
//        }

//        public bool Delete(int id)
//        {
//            Admin ad = _context.Admins.SingleOrDefault(admin => admin.ID == id);
//            _context.Admins.DefaultIfEmpty(ad);
//            _context.Entry(ad).State = System.Data.Entity.EntityState.Deleted;
//            return _context.SaveChanges() == 1;
//        }

//        public Admin GetAdmin(int id)
//        {
//            return _context.Admins.SingleOrDefault(ad => ad.ID == id);
//        }
//    }
//}
