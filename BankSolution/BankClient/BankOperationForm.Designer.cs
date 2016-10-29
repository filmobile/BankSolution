namespace BankClient
{
    partial class BankOperationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btCreateAccount = new System.Windows.Forms.Button();
            this.btShowBalance = new System.Windows.Forms.Button();
            this.btChargeBalance = new System.Windows.Forms.Button();
            this.btTransferMoney = new System.Windows.Forms.Button();
            this.currencyPanel1 = new BankClient.CurrencyPanel();
            this.pnMain1 = new BankClient.PnMain();
            this.simplePanel1 = new BankClient.SimplePanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(2, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(327, 184);
            this.dgvData.TabIndex = 2;
            // 
            // btCreateAccount
            // 
            this.btCreateAccount.Location = new System.Drawing.Point(347, 20);
            this.btCreateAccount.Name = "btCreateAccount";
            this.btCreateAccount.Size = new System.Drawing.Size(89, 30);
            this.btCreateAccount.TabIndex = 3;
            this.btCreateAccount.Text = "CreateAccount";
            this.btCreateAccount.UseVisualStyleBackColor = true;
            this.btCreateAccount.Click += new System.EventHandler(this.btCreateAccount_Click);
            // 
            // btShowBalance
            // 
            this.btShowBalance.Location = new System.Drawing.Point(347, 67);
            this.btShowBalance.Name = "btShowBalance";
            this.btShowBalance.Size = new System.Drawing.Size(89, 30);
            this.btShowBalance.TabIndex = 5;
            this.btShowBalance.Text = "ShowBalance";
            this.btShowBalance.UseVisualStyleBackColor = true;
            this.btShowBalance.Click += new System.EventHandler(this.btShowBalance_Click);
            // 
            // btChargeBalance
            // 
            this.btChargeBalance.Location = new System.Drawing.Point(347, 114);
            this.btChargeBalance.Name = "btChargeBalance";
            this.btChargeBalance.Size = new System.Drawing.Size(89, 31);
            this.btChargeBalance.TabIndex = 6;
            this.btChargeBalance.Text = "ChargeBalance";
            this.btChargeBalance.UseVisualStyleBackColor = true;
            this.btChargeBalance.Click += new System.EventHandler(this.btChargeBalance_Click);
            // 
            // btTransferMoney
            // 
            this.btTransferMoney.Location = new System.Drawing.Point(347, 162);
            this.btTransferMoney.Name = "btTransferMoney";
            this.btTransferMoney.Size = new System.Drawing.Size(89, 34);
            this.btTransferMoney.TabIndex = 8;
            this.btTransferMoney.Text = "TransferMoney";
            this.btTransferMoney.UseVisualStyleBackColor = true;
            this.btTransferMoney.Click += new System.EventHandler(this.btTransferMoney_Click);
            // 
            // currencyPanel1
            // 
            this.currencyPanel1.Location = new System.Drawing.Point(12, 202);
            this.currencyPanel1.Name = "currencyPanel1";
            this.currencyPanel1.Size = new System.Drawing.Size(126, 112);
            this.currencyPanel1.TabIndex = 9;
            // 
            // pnMain1
            // 
            this.pnMain1.Location = new System.Drawing.Point(488, 20);
            this.pnMain1.Name = "pnMain1";
            this.pnMain1.Size = new System.Drawing.Size(275, 261);
            this.pnMain1.TabIndex = 7;
            // 
            // simplePanel1
            // 
            this.simplePanel1.Location = new System.Drawing.Point(476, 20);
            this.simplePanel1.Name = "simplePanel1";
            this.simplePanel1.Size = new System.Drawing.Size(314, 282);
            this.simplePanel1.TabIndex = 4;
            // 
            // BankOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 323);
            this.Controls.Add(this.currencyPanel1);
            this.Controls.Add(this.btTransferMoney);
            this.Controls.Add(this.pnMain1);
            this.Controls.Add(this.btChargeBalance);
            this.Controls.Add(this.btShowBalance);
            this.Controls.Add(this.simplePanel1);
            this.Controls.Add(this.btCreateAccount);
            this.Controls.Add(this.dgvData);
            this.Name = "BankOperationForm";
            this.Text = "BankOperationForm";
            this.Load += new System.EventHandler(this.BankOperationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btCreateAccount;
        private SimplePanel simplePanel1;
        private System.Windows.Forms.Button btShowBalance;
        private System.Windows.Forms.Button btChargeBalance;
        private PnMain pnMain1;
        private System.Windows.Forms.Button btTransferMoney;
        private CurrencyPanel currencyPanel1;
    }
}