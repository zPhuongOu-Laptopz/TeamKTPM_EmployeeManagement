using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;
using System;

namespace EmployeeManagement_Service.Service.Basic.Functions
{
    public class ServiceStaffs
    {
        EmployeeManagementDBContext context = new EmployeeManagementDBContext();

        public ServiceStaffs()
        {

        }

        public bool CreateStaffs(PdbStaff staff)
        {
            return (new Staffs(context) { }.Create(staff));
        }

        public bool EditStaffs(PdbStaff staff)
        {
            return (new Staffs(context) { }.Update(staff));
        }

        public bool DeteleStaff(Guid id)
        {
            return (new Staffs(context) { }.Delete(id));
        }
    }
}
