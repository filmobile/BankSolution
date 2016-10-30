using System;
using System.Windows.Forms;
using BankAppServiceNS.Commands;
using BankClient.BaseControls;

namespace BankClient.Controls
{
    public partial class ChargeBalancePanel : BaseControl
    {
        public ChargeBalancePanel()
        {
            InitializeComponent();
        }

        private void ChargeBalancePanel_Load(object sender, EventArgs e)
        {
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            cbAccountIdCharge.DataSource = (Client.Execute(cmd) as ClientAccountAnswer).Accounts;
        }

        private void btSendMoney_Click(object sender, EventArgs e)
        {
            var cmd = new CreateFirstTransactionsCommand() { AccountId = (cbAccountIdCharge.SelectedItem as AccountDTO).Id, Sum = decimal.Parse(tbSumCharge.Text) };
            Client.Execute(cmd);
            MessageBox.Show("Transfer Success!");
            OnDialogResult(System.Windows.Forms.DialogResult.OK);
        }
    }
}
