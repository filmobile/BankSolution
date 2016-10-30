using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClient.BaseControls;
using BankClient.Controls;

namespace BankClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExceptionHandler.Init();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            if (BaseForm.ShowDialog("Авторизация", "Авторизация", new AuthorizePanel()) == DialogResult.OK )
            {
                var form = new BaseForm();
                form.Build("Банкомат", "Здравствуйте, " + Client.UserLoginIn, new BankOperationPanel());
                Application.Run(form);
            }             
        }
    }
}
