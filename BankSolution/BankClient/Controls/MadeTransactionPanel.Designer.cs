namespace BankClient.Controls
{
    partial class MadeTransactionPanel
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
            this.cbMadeTransactions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MadeTransactions";
            // 
            // cbMadeTransactions
            // 
            this.cbMadeTransactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMadeTransactions.FormattingEnabled = true;
            this.cbMadeTransactions.Location = new System.Drawing.Point(19, 64);
            this.cbMadeTransactions.Name = "cbMadeTransactions";
            this.cbMadeTransactions.Size = new System.Drawing.Size(277, 21);
            this.cbMadeTransactions.TabIndex = 1;
            // 
            // MadeTransactionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMadeTransactions);
            this.Controls.Add(this.label1);
            this.Name = "MadeTransactionPanel";
            this.Size = new System.Drawing.Size(308, 149);
            this.Load += new System.EventHandler(this.MadeTransactionPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMadeTransactions;
    }
}
