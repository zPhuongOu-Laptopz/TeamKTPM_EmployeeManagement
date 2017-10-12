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
            //Application.Run(new User.MainForm());
            //Application.Run(new User.ContractForm());
            //Application.Run(new User.LoginForm());
            //Application.Run(new User.SuppliesForm());
            //Application.Run(new User.ContractForm());
            //Application.Run(new User.EventForm());
            //Application.Run(new User.ContractForm());
            //Application.Run(new User.LoginForm());
            //Application.Run(new User.EmployeeForm());
            //Application.Run(new User.SuppliesForm());
            //Application.Run(new User.ContractForm());
            Application.Run(new User.SalaryForm());

        }
    }
}
