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
using BankAppServiceNS.BaseClasses;
using BankModel;



namespace BankClient
{
    public partial class BankOperationPanel : UserControl
    {
        public BankOperationPanel()
        {
            InitializeComponent();
            cmbCurrency.DataSource = Enum.GetValues(typeof(Currency));
        }


        private void btShowBalance_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new GetBalanceCommand() { AccountId = tbAccountId.Text };
                MessageBox.Show(((Client.Execute(cmd) as BalanceAnswer).Balans).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btGetClientData_Click(object sender, EventArgs e)
        {
         /*   try
            {

                var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
                foreach (var p in (Client.Execute(cmd) as ClientAccountAnswer).Accounts)
                    MessageBox.Show(p.Id, p.Currency.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
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

        private void BankOperationPanel_Load(object sender, EventArgs e)
        {

        }

        private void bnSendMoney_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new CreateFirstTransactionsCommand() { AccountId = tbAccountIdForTransf.Text, Sum = decimal.Parse(tbSum.Text) };
                Client.Execute(cmd);
                MessageBox.Show("Transfer Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new CreateTransactionCommand() { FromAccountId = tbFromAccountId.Text, ToAccountId = tbToAccountId.Text, Sum = decimal.Parse(tbSumForTransfer.Text) };
                Client.Execute(cmd);
                MessageBox.Show("Transfer Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bnSetCurrency_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(tbUS.Text) > 0 || decimal.Parse(tbEU.Text) >0 || decimal.Parse(tbUA.Text)>0)
                {
                    var cmd = new SetCurrencyCommand() { US = decimal.Parse(tbUS.Text), EU = decimal.Parse(tbEU.Text), UA = decimal.Parse(tbUA.Text) };
                    Client.Execute(cmd);
                }
                MessageBox.Show("Enter a positive number!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
