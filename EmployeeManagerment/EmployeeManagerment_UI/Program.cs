﻿using System;
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
            Application.Run(new User.AddEmployeeForm());
            Application.Run(new User.MainForm());
            Application.Run(new User.EmployeeForm());
=======
            Application.Run(new User.FeedbackForm());
>>>>>>> AnhPhuong
        }
    }
}
