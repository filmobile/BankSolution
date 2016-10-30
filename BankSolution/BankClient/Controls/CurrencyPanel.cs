using System;
using BankAppServiceNS.Commands;
using BankClient.BaseControls;

namespace BankClient.Controls
{
    public partial class CurrencyPanel : BaseControl
    {
        public CurrencyPanel()
        {
            InitializeComponent();
        }

        public void Build()
        {
            Random ran = new Random();
            tbUS.Text = Convert.ToString(1);
            tbEU.Text = string.Format("{0:#.##} ", (ran.NextDouble() * (0.95 - 0.75) + 0.75));
            tbUA.Text = Convert.ToString(ran.Next(25, 32));
        }

        private void btCurrency_Click(object sender, EventArgs e)
        {
            Build();
            var cmd = new SetCurrencyCommand() { US = decimal.Parse(tbUS.Text), EU = decimal.Parse(tbEU.Text), UA = decimal.Parse(tbUA.Text) };
            Client.Execute(cmd);
        }
    }
}
