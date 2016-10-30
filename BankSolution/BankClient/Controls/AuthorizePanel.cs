using System;
using System.Windows.Forms;
using BankAppServiceNS.Commands;
using BankClient.BaseControls;

namespace BankClient.Controls
{
    public partial class AuthorizePanel : BaseControl
    {
        public AuthorizePanel()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            var cmd = new LoginCommand() { UserLogin = tbUserLogin.Text, UserPassword = tbUserPassword.Text };
            Client.Execute(cmd);
            Client.UserLoginIn = tbUserLogin.Text;
            OnDialogResult(System.Windows.Forms.DialogResult.OK);
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            var cmd = new SignUpCommand() { UserLogin = tbUserLogin.Text, UserPassword = tbUserPassword.Text };
            Client.Execute(cmd);
            Client.UserLoginIn = tbUserLogin.Text;
            OnDialogResult(System.Windows.Forms.DialogResult.OK);
            MessageBox.Show("Registration Successfull!");
        }
    }
}
