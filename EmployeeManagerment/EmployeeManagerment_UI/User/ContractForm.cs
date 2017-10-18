using System;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Basic;
using EmployeeManagement_Service.Service.Module;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EmployeeManagerment_UI.User
{
    public partial class ContractForm : Form
    {
        string[] listBaoVe = { "Trưởng bảo vệ", "Bảo vệ" };
        List<string> listKeToan = new List<string>();
        List<string> listIT = new List<string>();
        
        public ContractForm()
        {
            InitializeComponent();
        }

        private void InsertDataforCombobox()
        {
            listKeToan.Add("Kế toán trưởng");
            listKeToan.Add("Kế toán");
            listIT.Add("Trưởng phòng IT");
            listIT.Add("Phó phòng IT");
            listIT.Add("Nhân viên IT");
        }

        private void btn_backcontract_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PdbContract GetInformation()
        {
            PdbContract con = new PdbContract();
            con.IDContract = Guid.NewGuid();
            con.PayForms = txt_payforms.Text;
            con.SignDate = dtp_signdate.Value;
            con.StartDate = dtp_startdate.Value;
            con.EndDate = dtp_enddate.Value;
            con.ContractType = txt_contracttype.Text;
            con.ContractDescription = rtxt_contractdescription.Text;
            return con;
        }

        private void GetAllData()
        {
            try
            {
                grid_listcontract.DataSource = new EmployeeManagement_Service.Service.Module.Contracts(new EmployeeManagementDBContext()) { }.ContractsAll();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }

        private void btn_reloadcontract_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            GetAllData();
            InsertDataforCombobox();
        }

        private void btn_addcontract_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            PdbContract con = new PdbContract();
            try
            {
                con = GetInformation();
                new EmployeeManagement_Service.Service.Module.Contracts(new EmployeeManagementDBContext()) { }.Add(con);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.InsertSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileInsert();
            }
        }

        private void EditEvent()
        {
            PdbContract con = new PdbContract();
            try
            {
                con = GetInformation();
                new EmployeeManagement_Service.Service.Module.Contracts(new EmployeeManagementDBContext()) { }.Edit(con);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.UpdateSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileEdit();
            }
        }

        private void grid_listcontract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grid_listcontract.CurrentCell.RowIndex;
            txt_contracttype.Text = grid_listcontract.Rows[index].Cells[0].Value.ToString().Trim();
            txt_payforms.Text = grid_listcontract.Rows[index].Cells[0].Value.ToString().Trim();
            
        }

        private void cbb_department_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cbb_department.SelectedIndex == 0)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listKeToan.Count; i++)
                {
                    cbb_position.Items.Add(listKeToan[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 1)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listBaoVe.Length; i++)
                {
                    cbb_position.Items.Add(listBaoVe[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 2)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listIT.Count; i++)
                {
                    cbb_position.Items.Add(listIT[i]);
                }
            }
        }
    }
}
