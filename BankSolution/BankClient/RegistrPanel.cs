using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppServiceNS.Commands;
using BankAppServiceNS.BaseClasses;

namespace BankClient
{
    public partial class RegistrPanel : UserControl
    {
        public RegistrPanel()
        {
            InitializeComponent();
        }

        public event EventHandler LoginSuccessfull;
        // метод для запуска события
        public void OnLoginSuccessfull()
        {
            if (this.LoginSuccessfull != null)
                this.LoginSuccessfull(this, EventArgs.Empty);
        }

        private void btEnterData_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SignUpCommand() { UserLogin = tbUserLogin.Text, UserPassword = tbUserPassword.Text };
                Client.Execute(cmd);
                Client.UserLoginIn = tbUserLogin.Text;
                OnLoginSuccessfull();
                MessageBox.Show("Registration Successfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
