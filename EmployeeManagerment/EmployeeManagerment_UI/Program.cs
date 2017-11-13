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
<<<<<<< HEAD
            Application.Run(new User.SalaryForm());
            Application.Run(new User.AddEmployeeForm());
            Application.Run(new User.EditEmployeeForm());
=======
            Application.Run(new User.FeedbackForm());
>>>>>>> dev-NgocPhuong
=======
            Application.Run(new User.EditEmployeeForm());
>>>>>>> dev-NgocPhuong
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
