namespace BankClient
{
    partial class BalancePanel
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
            this.AccId = new System.Windows.Forms.Label();
            this.cbAccountId = new System.Windows.Forms.ComboBox();
            this.btShowBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccId
            // 
            this.AccId.AutoSize = true;
            this.AccId.Location = new System.Drawing.Point(37, 26);
            this.AccId.Name = "AccId";
            this.AccId.Size = new System.Drawing.Size(56, 13);
            this.AccId.TabIndex = 0;
            this.AccId.Text = "AccountId";
            // 
            // cbAccountId
            // 
            this.cbAccountId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountId.FormattingEnabled = true;
            this.cbAccountId.Location = new System.Drawing.Point(40, 51);
            this.cbAccountId.Name = "cbAccountId";
            this.cbAccountId.Size = new System.Drawing.Size(121, 21);
            this.cbAccountId.TabIndex = 1;
            // 
            // btShowBalance
            // 
            this.btShowBalance.Location = new System.Drawing.Point(40, 105);
            this.btShowBalance.Name = "btShowBalance";
            this.btShowBalance.Size = new System.Drawing.Size(121, 23);
            this.btShowBalance.TabIndex = 2;
            this.btShowBalance.Text = "ShowBalance";
            this.btShowBalance.UseVisualStyleBackColor = true;
            this.btShowBalance.Click += new System.EventHandler(this.btShowBalance_Click);
            // 
            // BalancePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btShowBalance);
            this.Controls.Add(this.cbAccountId);
            this.Controls.Add(this.AccId);
            this.Name = "BalancePanel";
            this.Size = new System.Drawing.Size(213, 174);
            this.Load += new System.EventHandler(this.BalancePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccId;
        private System.Windows.Forms.ComboBox cbAccountId;
        private System.Windows.Forms.Button btShowBalance;
    }
}
