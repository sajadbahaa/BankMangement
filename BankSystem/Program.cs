using BankSystem.Clients;
using BankSystem.Login;
using BankSystem.People;
using BankSystem.TransActions.Deposit;
using BankSystem.TransActions.ShareScreen;
using BankSystem.Transfer;
using BankSystem.Users;
using BankSystem.Users.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUser());
        }
    }
}
