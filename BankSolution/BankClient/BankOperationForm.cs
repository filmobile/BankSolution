using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppServiceNS.Commands;

namespace BankClient
{
    public partial class BankOperationForm : Form
    {
        public BankOperationForm()
        {
            InitializeComponent();
         
        }
     
        private void BankOperationForm_Load(object sender, EventArgs e)
        {
        
        }
        private DataTable dataTable;
        public void Build()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("AccountId");
            dataTable.Columns.Add("Currency");
            dataTable.Columns.Add("Balance");
            dgvData.DataSource = dataTable;
        }
        private void bnClientData_Click(object sender, EventArgs e)
        {
            Build();
            var cmd = new GetClientAccountCommand() { UserLogin = Client.UserLoginIn };
            foreach (var p in (Client.Execute(cmd) as ClientAccountAnswer).Accounts)
            dataTable.Rows.Add(p.Id.ToString(), p.Currency.ToString(),p.Balance.ToString()); 
           
        }
    }
}
