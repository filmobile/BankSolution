using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppServiceNS.BaseClasses;
using BankAppServiceNS.Commands;


namespace BankClient
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
          
        }
    

        private void authorizePanel2_LoginSuccessfull(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
