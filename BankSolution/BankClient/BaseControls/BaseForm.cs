using System.Drawing;
using System.Windows.Forms;

namespace BankClient.BaseControls
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public void Build(string formCaption, string title, BaseControl control)
        {
            Text = formCaption;
            lbTitle.Text = title;
            control.Parent = this;
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            if (control.MinimumSize != Size.Empty)
            { 
                SetClientSizeCore(control.MinimumSize.Width, control.MinimumSize.Height + pnTop.Height);
                this.MinimumSize = Size;
            }
            control.DialogResult += (o, e) => this.DialogResult = e.DialogResult;
        }

        public static DialogResult ShowDialog(string formCaption, string title, BaseControl control)
        {
            var form = new BaseForm();
            form.Build(formCaption, title, control);
            return form.ShowDialog();
        }
    }
}
