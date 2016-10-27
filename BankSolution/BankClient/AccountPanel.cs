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
    public partial class AccountPanel : UserControl
    {
        public AccountPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new CreateAccountCommand() { UserLogin = Client.UserLoginIn, Currency = (Currency)cmbCurrency.SelectedItem };
                Client.Execute(cmd);
                MessageBox.Show("Account have been created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AccountPanel_Load(object sender, EventArgs e)
        {
            cmbCurrency.DataSource = Enum.GetValues(typeof(Currency));
        }
    }
}
