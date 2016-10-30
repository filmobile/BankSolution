using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient.BaseControls
{
    public class BaseControl : UserControl
    {
        public event EventHandler<DialogResultEventArgs> DialogResult = delegate { };

        protected void OnDialogResult(DialogResult dialogResult)
        {
            DialogResult(this, new DialogResultEventArgs { DialogResult  = dialogResult});
        }
    }

    public class DialogResultEventArgs : EventArgs
    {
        public DialogResult DialogResult { get; set; }
    }
}
