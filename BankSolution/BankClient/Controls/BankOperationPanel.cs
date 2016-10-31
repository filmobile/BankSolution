using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppServiceNS.Commands;
using BankClient.BaseControls;

namespace BankClient.Controls
{
    public partial class BankOperationPanel : BaseControl
    {
        public BankOperationPanel()
        {
            InitializeComponent();
            UpdateInterface();
        }

        void CreatePanel(BaseControl ctrl)
        {
            pnMain.Controls.Clear();
            ctrl.Parent = pnMain;
            ctrl.Dock = DockStyle.Fill;
            ctrl.DialogResult += (o, e) =>
            {
                if (e.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    UpdateInterface();
                    pnMain.Controls.Clear();
                }
            };
        }

        private void UpdateInterface()
        {
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            dgvAccounts.DataSource = (Client.Execute(cmd) as ClientAccountAnswer).Accounts;
        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            CreatePanel(new CreateAccountPanel());
        }

        private void btChargeBalance_Click(object sender, EventArgs e)
        {
            CreatePanel(new ChargeBalancePanel());
        }

        private void btTransferMoney_Click(object sender, EventArgs e)
        {
            CreatePanel(new TransferMoneyPanel());
        }

        private void btCurrency_Click(object sender, EventArgs e)
        {
            CreatePanel(new CurrencyPanel());
        }

        private void btMadeTransactions_Click(object sender, EventArgs e)
        {
            CreatePanel(new MadeTransactionPanel());
        }
    }
}
