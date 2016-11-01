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
using BankClient.BaseControls;

namespace BankClient.Controls
{
    public partial class CancelTransactionPanel : BaseControl
    {
        public CancelTransactionPanel()
        {
            InitializeComponent();
        }

        private void CancelTransactionPanel_Load(object sender, EventArgs e)
        {
            var cmd = new GetMadeTransactionCommand() { UserLogin = Client.UserLoginIn };
            cbCancelTransaction.DataSource = (Client.Execute(cmd) as MadeTransactionAnswer).Transactions;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            var cmd = new CancelTransactionCommand() {FromAccountId=(cbCancelTransaction.SelectedItem as MadeTransactionDTO).FromAccId,ToAccountId=(cbCancelTransaction.SelectedItem as MadeTransactionDTO).ToAccId,Sum=(cbCancelTransaction.SelectedItem as MadeTransactionDTO).SumAcc };
            Client.Execute(cmd);
            MessageBox.Show("Transaction Cancelled!");
            OnDialogResult(System.Windows.Forms.DialogResult.OK);
        }

        private void cbCancelTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
