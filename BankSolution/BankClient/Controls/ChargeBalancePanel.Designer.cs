using BankClient.BaseControls;

namespace BankClient.Controls
{
    partial class ChargeBalancePanel
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
            this.btSendMoney = new BankClient.BaseControls.ExButton();
            this.tbSumCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccountIdCharge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSendMoney
            // 
            this.btSendMoney.BackColor = System.Drawing.Color.Silver;
            this.btSendMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendMoney.Location = new System.Drawing.Point(172, 93);
            this.btSendMoney.Name = "btSendMoney";
            this.btSendMoney.Size = new System.Drawing.Size(110, 40);
            this.btSendMoney.TabIndex = 4;
            this.btSendMoney.Text = "SendMoney";
            this.btSendMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSendMoney.UseVisualStyleBackColor = true;
            this.btSendMoney.Click += new System.EventHandler(this.btSendMoney_Click);
            // 
            // tbSumCharge
            // 
            this.tbSumCharge.Location = new System.Drawing.Point(20, 104);
            this.tbSumCharge.Name = "tbSumCharge";
            this.tbSumCharge.Size = new System.Drawing.Size(121, 20);
            this.tbSumCharge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sum";
            // 
            // cbAccountIdCharge
            // 
            this.cbAccountIdCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountIdCharge.FormattingEnabled = true;
            this.cbAccountIdCharge.Location = new System.Drawing.Point(20, 40);
            this.cbAccountIdCharge.Name = "cbAccountIdCharge";
            this.cbAccountIdCharge.Size = new System.Drawing.Size(262, 21);
            this.cbAccountIdCharge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // ChargeBalancePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSendMoney);
            this.Controls.Add(this.tbSumCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountIdCharge);
            this.Controls.Add(this.label1);
            this.Name = "ChargeBalancePanel";
            this.Size = new System.Drawing.Size(306, 160);
            this.Load += new System.EventHandler(this.ChargeBalancePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccountIdCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSumCharge;
        private ExButton btSendMoney;
    }
}
