namespace BankClient.Controls
{
    partial class DeletedTransactonPanel
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
            this.cbDeletedTransaction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancelled Transactions";
            // 
            // cbDeletedTransaction
            // 
            this.cbDeletedTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeletedTransaction.FormattingEnabled = true;
            this.cbDeletedTransaction.Location = new System.Drawing.Point(22, 58);
            this.cbDeletedTransaction.Name = "cbDeletedTransaction";
            this.cbDeletedTransaction.Size = new System.Drawing.Size(241, 21);
            this.cbDeletedTransaction.TabIndex = 1;
            // 
            // DeletedTransactonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbDeletedTransaction);
            this.Controls.Add(this.label1);
            this.Name = "DeletedTransactonPanel";
            this.Size = new System.Drawing.Size(286, 153);
            this.Load += new System.EventHandler(this.DeletedTransactonPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDeletedTransaction;
    }
}
