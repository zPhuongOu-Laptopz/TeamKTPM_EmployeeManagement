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
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new User.MainForm());
=======
            //Application.Run(new User.SalaryForm());
            Application.Run(new User.AccountForm());
>>>>>>> Phuc
=======
            Application.Run(new User.EducationLevelForm());
            Application.Run(new User.SalaryForm());
>>>>>>> AnhPhuong
        }
    }
}
