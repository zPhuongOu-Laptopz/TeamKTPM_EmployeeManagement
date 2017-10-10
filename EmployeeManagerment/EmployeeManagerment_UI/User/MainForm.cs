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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_listemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
            // Chưa xong.
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
            // tải lại
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
