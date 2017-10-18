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
        List<string> listBaoVe = new List<string>();
        List<string> listKeToan = new List<string>();
        List<string> listIT = new List<string>();
        List<string> listKinhDoanh = new List<string>();
        List<string> listNhanSu = new List<string>();
        
        public ContractForm()
        {
            InitializeComponent();
        }

        private void InsertDataforCombobox()
        {
            listKeToan.Add("Kế toán trưởng");
            listKeToan.Add("Nhân viên");
            listIT.Add("Giám đốc CNTT");
            listIT.Add("Thiết kế viên");
            listIT.Add("Lập trình viên");
            listBaoVe.Add("Tổ trưởng");
            listBaoVe.Add("Bảo vệ");
            listKinhDoanh.Add("Trưởng phòng kinh doanh");
            listKinhDoanh.Add("Nhân viên");
            listNhanSu.Add("Trưởng phòng nhân sự");
            listNhanSu.Add("Nhân viên");
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
                for (int i = 0; i < listBaoVe.Count; i++)
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
            else if (cbb_department.SelectedIndex == 3)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listKinhDoanh.Count; i++)
                {
                    cbb_position.Items.Add(listKinhDoanh[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 4)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listNhanSu.Count; i++)
                {
                    cbb_position.Items.Add(listNhanSu[i]);
                }
            }
        }
    }
}
