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
    public partial class ChargeBalancePanel : UserControl
    {
        public ChargeBalancePanel()
        {
            InitializeComponent();
        }

        private void ChargeBalancePanel_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            foreach (var p in (Client.Execute(cmd) as ClientAccountAnswer).Accounts)
                list.Add(p.Id.ToString());
            cbAccountIdCharge.DataSource = list;
        }

        private void btSendMoney_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new CreateFirstTransactionsCommand() { AccountId = cbAccountIdCharge.SelectedItem.ToString(), Sum = decimal.Parse(tbSumCharge.Text) };
                Client.Execute(cmd);
                MessageBox.Show("Transfer Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
