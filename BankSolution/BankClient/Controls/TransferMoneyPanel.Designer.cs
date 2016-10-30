using BankClient.BaseControls;

namespace BankClient.Controls
{
    partial class TransferMoneyPanel
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
            this.cbFromAccountId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSumTransfer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btTransferMoney = new BankClient.BaseControls.ExButton();
            this.tbToAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FromAccount";
            // 
            // cbFromAccountId
            // 
            this.cbFromAccountId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromAccountId.FormattingEnabled = true;
            this.cbFromAccountId.Location = new System.Drawing.Point(19, 34);
            this.cbFromAccountId.Name = "cbFromAccountId";
            this.cbFromAccountId.Size = new System.Drawing.Size(316, 21);
            this.cbFromAccountId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ToAccountId";
            // 
            // tbSumTransfer
            // 
            this.tbSumTransfer.Location = new System.Drawing.Point(19, 142);
            this.tbSumTransfer.Name = "tbSumTransfer";
            this.tbSumTransfer.Size = new System.Drawing.Size(118, 20);
            this.tbSumTransfer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum";
            // 
            // btTransferMoney
            // 
            this.btTransferMoney.BackColor = System.Drawing.Color.Silver;
            this.btTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransferMoney.Location = new System.Drawing.Point(225, 131);
            this.btTransferMoney.Name = "btTransferMoney";
            this.btTransferMoney.Size = new System.Drawing.Size(110, 40);
            this.btTransferMoney.TabIndex = 6;
            this.btTransferMoney.Text = "TransferMoney";
            this.btTransferMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTransferMoney.UseVisualStyleBackColor = true;
            this.btTransferMoney.Click += new System.EventHandler(this.btTransferMoney_Click);
            // 
            // tbToAccount
            // 
            this.tbToAccount.Location = new System.Drawing.Point(19, 83);
            this.tbToAccount.Name = "tbToAccount";
            this.tbToAccount.Size = new System.Drawing.Size(316, 20);
            this.tbToAccount.TabIndex = 7;
            // 
            // TransferMoneyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbToAccount);
            this.Controls.Add(this.btTransferMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSumTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFromAccountId);
            this.Controls.Add(this.label1);
            this.Name = "TransferMoneyPanel";
            this.Size = new System.Drawing.Size(362, 207);
            this.Load += new System.EventHandler(this.TransferMoneyPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFromAccountId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSumTransfer;
        private System.Windows.Forms.Label label3;
        private ExButton btTransferMoney;
        private System.Windows.Forms.TextBox tbToAccount;
    }
}
