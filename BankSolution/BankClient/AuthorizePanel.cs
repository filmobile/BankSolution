using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppServiceNS.BaseClasses;
using BankAppServiceNS.Commands;



namespace BankClient
{
    public partial class AuthorizePanel : UserControl
    {
        public AuthorizePanel()
        {
            InitializeComponent();
            
        }

        public event EventHandler LoginSuccessfull;
        // метод для запуска события
        public void OnLoginSuccessfull()
        {
            if (this.LoginSuccessfull != null)
                this.LoginSuccessfull(this,EventArgs.Empty);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new LoginCommand() { UserLogin = tbUserLogin.Text, UserPassword = tbUserPassword.Text };
                Client.Execute(cmd);
                Client.UserLoginIn = tbUserLogin.Text;
                OnLoginSuccessfull();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new RegistrationForm();
                form.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
