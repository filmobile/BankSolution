using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClient.BaseControls;
using BankAppServiceNS.Commands;

namespace BankClient.Controls
{
    public partial class MadeTransactionPanel : BaseControl
    {
        public MadeTransactionPanel()
        {
            InitializeComponent();
        }

        private void MadeTransactionPanel_Load(object sender, EventArgs e)
        {
            var cmd = new GetMadeTransactionCommand() { UserLogin = Client.UserLoginIn };
            cbMadeTransactions.DataSource = (Client.Execute(cmd) as MadeTransactionAnswer).Transactions;
        }
    }
}
