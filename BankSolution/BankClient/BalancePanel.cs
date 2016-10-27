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
    public partial class BalancePanel : UserControl
    {
        public BalancePanel()
        {
            InitializeComponent();
        }

        private void BalancePanel_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            foreach (var p in (Client.Execute(cmd) as ClientAccountAnswer).Accounts)
                list.Add(p.Id.ToString());
            cbAccountId.DataSource = list;

        }

        private void btShowBalance_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new GetBalanceCommand() { AccountId = cbAccountId.SelectedItem.ToString() };
                MessageBox.Show(((Client.Execute(cmd) as BalanceAnswer).Balans).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
