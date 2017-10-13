using EmployeeManagement_Service.ModelDBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //GetAllData();
        }

        private void btn_addeditemployee_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.EmployeeForm employeeform = new EmployeeForm();
            this.Visible = true;
            employeeform.ShowDialog();
            this.Visible = false;
        }

        private void btn_addeditsalary_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.SalaryForm salary = new SalaryForm();
            this.Visible = true;
            salary.ShowDialog();
            this.Visible = false;
        }

        private void btn_accountmanagement_Click(object sender, EventArgs e)
        {
            // Chưa xong.   
        }

        private void btn_addeditevent_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.EventForm eventform = new EventForm();
            this.Visible = true;
            eventform.ShowDialog();
            this.Visible = false;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void GetAllData()
        {
            try
            {
                grid_listemployee.DataSource = new EmployeeManagement_Service.Service.Module.Staffs(new EmployeeManagementDBContext()) { }.GetAllStaff();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }

        private void bnt_supplier_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.SuppliesForm suppliesform = new SuppliesForm();
            this.Visible = true;
            suppliesform.ShowDialog();
            this.Visible = false;
        }
    }
}
