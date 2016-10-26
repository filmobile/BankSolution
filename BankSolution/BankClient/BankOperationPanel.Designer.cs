namespace BankClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccountId = new System.Windows.Forms.TextBox();
            this.btShowBalance = new System.Windows.Forms.Button();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAccountIdForTransf = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.bnSendMoney = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFromAccountId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbToAccountId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSumForTransfer = new System.Windows.Forms.TextBox();
            this.bnTransfer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUS = new System.Windows.Forms.TextBox();
            this.EU = new System.Windows.Forms.Label();
            this.tbEU = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbUA = new System.Windows.Forms.TextBox();
            this.bnSetCurrency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AccountId";
            // 
            // tbAccountId
            // 
            this.tbAccountId.Location = new System.Drawing.Point(112, 112);
            this.tbAccountId.Name = "tbAccountId";
            this.tbAccountId.Size = new System.Drawing.Size(100, 20);
            this.tbAccountId.TabIndex = 2;
            // 
            // btShowBalance
            // 
            this.btShowBalance.Location = new System.Drawing.Point(240, 112);
            this.btShowBalance.Name = "btShowBalance";
            this.btShowBalance.Size = new System.Drawing.Size(87, 23);
            this.btShowBalance.TabIndex = 3;
            this.btShowBalance.Text = "ShowBalance";
            this.btShowBalance.UseVisualStyleBackColor = true;
            this.btShowBalance.Click += new System.EventHandler(this.btShowBalance_Click);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(123, 48);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(104, 21);
            this.cmbCurrency.TabIndex = 9;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CreateAccount";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(240, 48);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(87, 23);
            this.CreateAccount.TabIndex = 11;
            this.CreateAccount.Text = "CreateAccount";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Transfer money to Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "AccountId";
            // 
            // tbAccountIdForTransf
            // 
            this.tbAccountIdForTransf.Location = new System.Drawing.Point(123, 195);
            this.tbAccountIdForTransf.Name = "tbAccountIdForTransf";
            this.tbAccountIdForTransf.Size = new System.Drawing.Size(89, 20);
            this.tbAccountIdForTransf.TabIndex = 14;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(247, 195);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(28, 13);
            this.Sum.TabIndex = 15;
            this.Sum.Text = "Sum";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(308, 192);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 20);
            this.tbSum.TabIndex = 16;
            // 
            // bnSendMoney
            // 
            this.bnSendMoney.Location = new System.Drawing.Point(453, 189);
            this.bnSendMoney.Name = "bnSendMoney";
            this.bnSendMoney.Size = new System.Drawing.Size(75, 23);
            this.bnSendMoney.TabIndex = 17;
            this.bnSendMoney.Text = "SendMoney";
            this.bnSendMoney.UseVisualStyleBackColor = true;
            this.bnSendMoney.Click += new System.EventHandler(this.bnSendMoney_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Transfer money between Accounts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "FromAccountId";
            // 
            // tbFromAccountId
            // 
            this.tbFromAccountId.Location = new System.Drawing.Point(84, 286);
            this.tbFromAccountId.Name = "tbFromAccountId";
            this.tbFromAccountId.Size = new System.Drawing.Size(100, 20);
            this.tbFromAccountId.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ToAccountId";
            // 
            // tbToAccountId
            // 
            this.tbToAccountId.Location = new System.Drawing.Point(265, 287);
            this.tbToAccountId.Name = "tbToAccountId";
            this.tbToAccountId.Size = new System.Drawing.Size(100, 20);
            this.tbToAccountId.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sum";
            // 
            // tbSumForTransfer
            // 
            this.tbSumForTransfer.Location = new System.Drawing.Point(405, 286);
            this.tbSumForTransfer.Name = "tbSumForTransfer";
            this.tbSumForTransfer.Size = new System.Drawing.Size(100, 20);
            this.tbSumForTransfer.TabIndex = 24;
            // 
            // bnTransfer
            // 
            this.bnTransfer.Location = new System.Drawing.Point(528, 279);
            this.bnTransfer.Name = "bnTransfer";
            this.bnTransfer.Size = new System.Drawing.Size(82, 23);
            this.bnTransfer.TabIndex = 25;
            this.bnTransfer.Text = "Transfer";
            this.bnTransfer.UseVisualStyleBackColor = true;
            this.bnTransfer.Click += new System.EventHandler(this.bnTransfer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "US";
            // 
            // tbUS
            // 
            this.tbUS.Location = new System.Drawing.Point(438, 23);
            this.tbUS.Name = "tbUS";
            this.tbUS.Size = new System.Drawing.Size(67, 20);
            this.tbUS.TabIndex = 27;
            // 
            // EU
            // 
            this.EU.AutoSize = true;
            this.EU.Location = new System.Drawing.Point(391, 53);
            this.EU.Name = "EU";
            this.EU.Size = new System.Drawing.Size(22, 13);
            this.EU.TabIndex = 28;
            this.EU.Text = "EU";
            // 
            // tbEU
            // 
            this.tbEU.Location = new System.Drawing.Point(439, 51);
            this.tbEU.Name = "tbEU";
            this.tbEU.Size = new System.Drawing.Size(66, 20);
            this.tbEU.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "UA";
            // 
            // tbUA
            // 
            this.tbUA.Location = new System.Drawing.Point(438, 76);
            this.tbUA.Name = "tbUA";
            this.tbUA.Size = new System.Drawing.Size(64, 20);
            this.tbUA.TabIndex = 31;
            // 
            // bnSetCurrency
            // 
            this.bnSetCurrency.Location = new System.Drawing.Point(508, 74);
            this.bnSetCurrency.Name = "bnSetCurrency";
            this.bnSetCurrency.Size = new System.Drawing.Size(75, 23);
            this.bnSetCurrency.TabIndex = 32;
            this.bnSetCurrency.Text = "SetCurrency";
            this.bnSetCurrency.UseVisualStyleBackColor = true;
            this.bnSetCurrency.Click += new System.EventHandler(this.bnSetCurrency_Click);
            // 
            // BankOperationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnSetCurrency);
            this.Controls.Add(this.tbUA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbEU);
            this.Controls.Add(this.EU);
            this.Controls.Add(this.tbUS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bnTransfer);
            this.Controls.Add(this.tbSumForTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbToAccountId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbFromAccountId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bnSendMoney);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.tbAccountIdForTransf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.btShowBalance);
            this.Controls.Add(this.tbAccountId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BankOperationPanel";
            this.Size = new System.Drawing.Size(619, 348);
            this.Load += new System.EventHandler(this.BankOperationPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccountId;
        private System.Windows.Forms.Button btShowBalance;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAccountIdForTransf;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Button bnSendMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFromAccountId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbToAccountId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSumForTransfer;
        private System.Windows.Forms.Button bnTransfer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUS;
        private System.Windows.Forms.Label EU;
        private System.Windows.Forms.TextBox tbEU;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbUA;
        private System.Windows.Forms.Button bnSetCurrency;
    }
}
