using System.Windows.Forms;

namespace EmployeeManagement_Service.Service.Basic.Notification
{
    public class SuccessfulNotification
    {
        public void LoginSuccessful()
        {
            MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
