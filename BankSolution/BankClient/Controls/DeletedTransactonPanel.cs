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
    public partial class DeletedTransactonPanel : BaseControl
    {
        public DeletedTransactonPanel()
        {
            InitializeComponent();
        }

        private void DeletedTransactonPanel_Load(object sender, EventArgs e)
        {
            var cmd = new GetCancelTransactionCommand() { UserLogin = Client.UserLoginIn };
            cbDeletedTransaction.DataSource = (Client.Execute(cmd) as CancelTransactionAnswer).CancelTransactions;
        }
    }
}
