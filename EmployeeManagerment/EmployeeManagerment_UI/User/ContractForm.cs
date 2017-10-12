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
        public ContractForm()
        {
            InitializeComponent();
        }

        private void btn_backcontract_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetInformation()
        {
            PdbContract con = new PdbContract();
            con.IDContract = Guid.NewGuid();
            con.PayForms = txt_payforms.Text;
            con.SignDate = dtp_signdate.Value;
            con.StartDate = dtp_startdate.Value;
            con.EndDate = dtp_enddate.Value;
            con.ContractType = txt_contracttype.Text;
            con.ContractDescription = rtxt_contractdescription.Text;           
        }
    }
}
