using System;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Basic;
using EmployeeManagement_Service.Service.Module;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EmployeeManagerment_UI.User
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void GetAllData()
        {
            grid_listevent.DataSource = new EmployeeManagement_Service.Service.Module.Events(new EmployeeManagementDBContext()) { }.EventsAll();
        }

        private void btn_backevent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addevent_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void AddEvent()
        {
            PdbEvent eve = new PdbEvent();
            try
            {
                eve = GetInfomation();
                new EmployeeManagement_Service.Service.Module.Events(new EmployeeManagementDBContext()) { }.Add(eve);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.InsertSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileInsert();
            }
        }

        private void EditEvent()
        {
            PdbEvent eve = new PdbEvent();
            try
            {
                eve = GetInfomation();
                new EmployeeManagement_Service.Service.Module.Events(new EmployeeManagementDBContext()) { }.Add(eve);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.UpdateSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileEdit();
            }
        }

        private PdbEvent GetInfomation()
        {
            PdbEvent eve = new PdbEvent();
            eve.ID_Event = Guid.NewGuid();
            eve.EventName = txt_eventname.Text;
            eve.CostsAwarded = Convert.ToDecimal(txt_costawarded.Text);
            eve.ExpectedCost = Convert.ToDecimal(txt_expectedcost.Text);
            eve.ActualCosts = Convert.ToDecimal(txt_actualcost.Text);
            eve.Scale = txt_scale.Text;
            eve.Location = txt_location.Text;
            eve.DateStart = dtp_datestart.Value;
            eve.DateEnd = dtp_dateend.Value;
            eve.TravelBy = txt_travelby.Text;
            eve.EventContent = rtxt_eventcontent.Text;
            eve.Money_Staff_Pay = Convert.ToDecimal(txt_moneystaffpay.Text);
            return eve;
        }

        private void btn_reloadevent_Click(object sender, EventArgs e)
        {
            GetAllData();
        }
    }
}
