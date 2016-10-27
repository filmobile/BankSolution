namespace BankClient
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
            this.cbToAccountId = new System.Windows.Forms.ComboBox();
            this.tbSumTransfer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btTransferMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FromAccountId";
            // 
            // cbFromAccountId
            // 
            this.cbFromAccountId.FormattingEnabled = true;
            this.cbFromAccountId.Location = new System.Drawing.Point(34, 53);
            this.cbFromAccountId.Name = "cbFromAccountId";
            this.cbFromAccountId.Size = new System.Drawing.Size(121, 21);
            this.cbFromAccountId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ToAccountId";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbToAccountId
            // 
            this.cbToAccountId.FormattingEnabled = true;
            this.cbToAccountId.Location = new System.Drawing.Point(37, 119);
            this.cbToAccountId.Name = "cbToAccountId";
            this.cbToAccountId.Size = new System.Drawing.Size(118, 21);
            this.cbToAccountId.TabIndex = 3;
            // 
            // tbSumTransfer
            // 
            this.tbSumTransfer.Location = new System.Drawing.Point(37, 170);
            this.tbSumTransfer.Name = "tbSumTransfer";
            this.tbSumTransfer.Size = new System.Drawing.Size(118, 20);
            this.tbSumTransfer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum";
            // 
            // btTransferMoney
            // 
            this.btTransferMoney.Location = new System.Drawing.Point(37, 214);
            this.btTransferMoney.Name = "btTransferMoney";
            this.btTransferMoney.Size = new System.Drawing.Size(118, 23);
            this.btTransferMoney.TabIndex = 6;
            this.btTransferMoney.Text = "TransferMoney";
            this.btTransferMoney.UseVisualStyleBackColor = true;
            this.btTransferMoney.Click += new System.EventHandler(this.btTransferMoney_Click);
            // 
            // TransferMoneyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btTransferMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSumTransfer);
            this.Controls.Add(this.cbToAccountId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFromAccountId);
            this.Controls.Add(this.label1);
            this.Name = "TransferMoneyPanel";
            this.Size = new System.Drawing.Size(212, 248);
            this.Load += new System.EventHandler(this.TransferMoneyPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFromAccountId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbToAccountId;
        private System.Windows.Forms.TextBox tbSumTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTransferMoney;
    }
}
