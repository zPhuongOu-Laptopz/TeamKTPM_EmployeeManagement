using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerment_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //------NgocPhuong-----------------
            //Application.Run(new User.AddEmployeeForm());
<<<<<<< HEAD

            Application.Run(new User.AccountForm());
            //Application.Run(new User.SalaryForm());
            //Application.Run(new User.AddEmployeeForm());
            //Application.Run(new User.EditEmployeeForm());
            //Application.Run(new User.FeedbackForm());

=======
            Application.Run(new User.AddEmployeeForm());
            //Application.Run(new User.AddEmployeeForm());            
>>>>>>> 398d85e54e127939666f0b2394674e53d61e3eec
            //---------------------------------

            //------Phuc-----------------------
            //Application.Run(new User.LoginForm());
            //---------------------------------

            //------Khanh----------------------
            //Application.Run(new User.LoginForm());
            //---------------------------------

            //------QuangTerry-----------------
            //Application.Run(new User.LoginForm());
            //---------------------------------

            //------AnhPhuong------------------
            //Application.Run(new User.LoginForm());
            //---------------------------------

        }
    }
}
