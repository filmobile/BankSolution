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
using BankModel;

namespace BankClient
{
    public partial class TransferMoneyPanel : UserControl
    {
        public TransferMoneyPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btTransferMoney_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFromAccountId.SelectedItem.ToString() != cbToAccountId.SelectedItem.ToString())
                {
                    var cmd = new CreateTransactionCommand() { FromAccountId = cbFromAccountId.SelectedItem.ToString(), ToAccountId = cbToAccountId.SelectedItem.ToString(), Sum = decimal.Parse(tbSumTransfer.Text) };
                    Client.Execute(cmd);
                    MessageBox.Show("Transfer Success!");
                }
                MessageBox.Show("Can't transfer from same Account!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransferMoneyPanel_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            foreach (var p in (Client.Execute(cmd) as ClientAccountAnswer).Accounts)
                list.Add(p.Id.ToString());
            cbFromAccountId.DataSource = list;
            cbToAccountId.DataSource = list;
        }
    }
}
