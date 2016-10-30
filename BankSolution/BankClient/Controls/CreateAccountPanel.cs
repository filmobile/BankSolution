using System;
using System.Windows.Forms;
using BankAppServiceNS.Commands;
using BankClient.BaseControls;
using BankModel;

namespace BankClient.Controls
{
    public partial class CreateAccountPanel : BaseControl
    {
        public CreateAccountPanel()
        {
            InitializeComponent();
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            var cmd = new CreateAccountCommand() { UserLogin = Client.UserLoginIn, Currency = (Currency)cmbCurrency.SelectedItem };
            Client.Execute(cmd);
            MessageBox.Show("Account have been created!");
            OnDialogResult(System.Windows.Forms.DialogResult.OK);
        }

        private void AccountPanel_Load(object sender, EventArgs e)
        {
            cmbCurrency.DataSource = Enum.GetValues(typeof(Currency));
        }
    }
}
