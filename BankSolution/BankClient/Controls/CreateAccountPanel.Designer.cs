using BankClient.BaseControls;

namespace BankClient.Controls
{
    partial class CreateAccountPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.btCreateAccount = new BankClient.BaseControls.ExButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SelectCurrency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(35, 38);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrency.TabIndex = 1;
            // 
            // btCreateAccount
            // 
            this.btCreateAccount.BackColor = System.Drawing.Color.Silver;
            this.btCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateAccount.Location = new System.Drawing.Point(35, 94);
            this.btCreateAccount.Name = "btCreateAccount";
            this.btCreateAccount.Size = new System.Drawing.Size(110, 40);
            this.btCreateAccount.TabIndex = 2;
            this.btCreateAccount.Text = "CreateAccount";
            this.btCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCreateAccount.UseVisualStyleBackColor = true;
            this.btCreateAccount.Click += new System.EventHandler(this.btCreateAccount_Click);
            // 
            // CreateAccountPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCreateAccount);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountPanel";
            this.Size = new System.Drawing.Size(202, 175);
            this.Load += new System.EventHandler(this.AccountPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private ExButton btCreateAccount;
    }
}
