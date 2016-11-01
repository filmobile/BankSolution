namespace BankClient.Controls
{
    partial class BankOperationPanel
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btCurrency = new BankClient.BaseControls.ExButton();
            this.btCreateAccount = new BankClient.BaseControls.ExButton();
            this.btTransferMoney = new BankClient.BaseControls.ExButton();
            this.btChargeBalance = new BankClient.BaseControls.ExButton();
            this.btMadeTransactions = new BankClient.BaseControls.ExButton();
            this.btCancelTransaction = new BankClient.BaseControls.ExButton();
            this.btDeletedTransaction = new BankClient.BaseControls.ExButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.Location = new System.Drawing.Point(3, 125);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(591, 318);
            this.pnMain.TabIndex = 17;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 7);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.Size = new System.Drawing.Size(591, 112);
            this.dgvAccounts.TabIndex = 12;
            // 
            // btCurrency
            // 
            this.btCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCurrency.BackColor = System.Drawing.Color.Silver;
            this.btCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCurrency.Location = new System.Drawing.Point(600, 403);
            this.btCurrency.Name = "btCurrency";
            this.btCurrency.Size = new System.Drawing.Size(110, 40);
            this.btCurrency.TabIndex = 18;
            this.btCurrency.Text = "Currency";
            this.btCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCurrency.UseVisualStyleBackColor = true;
            this.btCurrency.Click += new System.EventHandler(this.btCurrency_Click);
            // 
            // btCreateAccount
            // 
            this.btCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateAccount.BackColor = System.Drawing.Color.Silver;
            this.btCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateAccount.Location = new System.Drawing.Point(600, 125);
            this.btCreateAccount.Name = "btCreateAccount";
            this.btCreateAccount.Size = new System.Drawing.Size(110, 40);
            this.btCreateAccount.TabIndex = 13;
            this.btCreateAccount.Text = "CreateAccount";
            this.btCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCreateAccount.UseVisualStyleBackColor = true;
            this.btCreateAccount.Click += new System.EventHandler(this.btCreateAccount_Click);
            // 
            // btTransferMoney
            // 
            this.btTransferMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTransferMoney.BackColor = System.Drawing.Color.Silver;
            this.btTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransferMoney.Location = new System.Drawing.Point(600, 221);
            this.btTransferMoney.Name = "btTransferMoney";
            this.btTransferMoney.Size = new System.Drawing.Size(110, 40);
            this.btTransferMoney.TabIndex = 16;
            this.btTransferMoney.Text = "TransferMoney";
            this.btTransferMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTransferMoney.UseVisualStyleBackColor = true;
            this.btTransferMoney.Click += new System.EventHandler(this.btTransferMoney_Click);
            // 
            // btChargeBalance
            // 
            this.btChargeBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChargeBalance.BackColor = System.Drawing.Color.Silver;
            this.btChargeBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChargeBalance.Location = new System.Drawing.Point(600, 173);
            this.btChargeBalance.Name = "btChargeBalance";
            this.btChargeBalance.Size = new System.Drawing.Size(110, 40);
            this.btChargeBalance.TabIndex = 15;
            this.btChargeBalance.Text = "ChargeBalance";
            this.btChargeBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChargeBalance.UseVisualStyleBackColor = true;
            this.btChargeBalance.Click += new System.EventHandler(this.btChargeBalance_Click);
            // 
            // btMadeTransactions
            // 
            this.btMadeTransactions.BackColor = System.Drawing.Color.Silver;
            this.btMadeTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMadeTransactions.Location = new System.Drawing.Point(600, 267);
            this.btMadeTransactions.Name = "btMadeTransactions";
            this.btMadeTransactions.Size = new System.Drawing.Size(110, 41);
            this.btMadeTransactions.TabIndex = 19;
            this.btMadeTransactions.Text = "ShowTransactions";
            this.btMadeTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMadeTransactions.UseVisualStyleBackColor = false;
            this.btMadeTransactions.Click += new System.EventHandler(this.btMadeTransactions_Click);
            // 
            // btCancelTransaction
            // 
            this.btCancelTransaction.BackColor = System.Drawing.Color.Silver;
            this.btCancelTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelTransaction.Location = new System.Drawing.Point(600, 314);
            this.btCancelTransaction.Name = "btCancelTransaction";
            this.btCancelTransaction.Size = new System.Drawing.Size(110, 40);
            this.btCancelTransaction.TabIndex = 20;
            this.btCancelTransaction.Text = "CancelTransaction";
            this.btCancelTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelTransaction.UseVisualStyleBackColor = false;
            this.btCancelTransaction.Click += new System.EventHandler(this.btCancelTransaction_Click);
            // 
            // btDeletedTransaction
            // 
            this.btDeletedTransaction.BackColor = System.Drawing.Color.Silver;
            this.btDeletedTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletedTransaction.Location = new System.Drawing.Point(600, 361);
            this.btDeletedTransaction.Name = "btDeletedTransaction";
            this.btDeletedTransaction.Size = new System.Drawing.Size(110, 36);
            this.btDeletedTransaction.TabIndex = 21;
            this.btDeletedTransaction.Text = "DeletedTransaction";
            this.btDeletedTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletedTransaction.UseVisualStyleBackColor = false;
            this.btDeletedTransaction.Click += new System.EventHandler(this.btDeletedTransaction_Click);
            // 
            // BankOperationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btDeletedTransaction);
            this.Controls.Add(this.btCancelTransaction);
            this.Controls.Add(this.btMadeTransactions);
            this.Controls.Add(this.btCurrency);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.btCreateAccount);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.btTransferMoney);
            this.Controls.Add(this.btChargeBalance);
            this.MinimumSize = new System.Drawing.Size(718, 461);
            this.Name = "BankOperationPanel";
            this.Size = new System.Drawing.Size(718, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.ExButton btCurrency;
        private System.Windows.Forms.Panel pnMain;
        private BaseControls.ExButton btTransferMoney;
        private BaseControls.ExButton btChargeBalance;
        private BaseControls.ExButton btCreateAccount;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private BaseControls.ExButton btMadeTransactions;
        private BaseControls.ExButton btCancelTransaction;
        private BaseControls.ExButton btDeletedTransaction;
    }
}
