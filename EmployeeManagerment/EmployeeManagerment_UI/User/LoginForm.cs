using System;
using EmployeeManagement_Service.Service.Module;
using EmployeeManagement_Service.ModelDBContext;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CheckPassWordChar();
        }

        private void cbremember_CheckedChanged(object sender, EventArgs e)
        {
            CheckPassWordChar();
        }

        public void CheckPassWordChar()
        {
            if (cbremember.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
                cbremember.Text = "Show";
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
                cbremember.Text = "Don't Show";
            }
        }

        //Button for login
        private void bntlogin_Click(object sender, EventArgs e)
        {
            PdbAccount ac = new EmployeeManagement_Service.Service.Basic.Functions.UserLogins { }.CheckLogin(txtusername.ToString(),txtpassword.ToString(),cbbdepartment.ToString());
            if (ac != null)
            {
                MainForm mainform = new MainForm();
                this.Visible = true;
                mainform.ShowDialog();
                txtusername.Text = "";
                txtpassword.Text = "";
                this.Visible = false;
            }
        }
    }
}
