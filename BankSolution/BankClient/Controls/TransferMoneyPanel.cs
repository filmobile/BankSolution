using System;
using System.Windows.Forms;
using BankAppServiceNS.Commands;
using BankClient.BaseControls;

namespace BankClient.Controls
{
    public partial class TransferMoneyPanel : BaseControl
    {
        public TransferMoneyPanel()
        {
            InitializeComponent();
        }
        private void btTransferMoney_Click(object sender, EventArgs e)
        {
            var cmd = new CreateTransactionCommand() { FromAccountId = (cbFromAccountId.SelectedItem as AccountDTO).Id, ToAccountId = tbToAccount.Text, Sum = decimal.Parse(tbSumTransfer.Text) };
            Client.Execute(cmd);
            MessageBox.Show("Transfer Success!");
            OnDialogResult(System.Windows.Forms.DialogResult.OK);
        }

        private void TransferMoneyPanel_Load(object sender, EventArgs e)
        {
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            cbFromAccountId.DataSource = (Client.Execute(cmd) as ClientAccountAnswer).Accounts;
        }
    }
}
