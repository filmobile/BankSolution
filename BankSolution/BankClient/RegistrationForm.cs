using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
           
        }

        private void registrPanel1_LoginSuccessfull(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
