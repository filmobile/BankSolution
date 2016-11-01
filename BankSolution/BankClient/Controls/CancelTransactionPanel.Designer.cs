namespace BankClient.Controls
{
    partial class CancelTransactionPanel
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
            this.cbCancelTransaction = new System.Windows.Forms.ComboBox();
            this.btCancel = new BankClient.BaseControls.ExButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Transaction";
            // 
            // cbCancelTransaction
            // 
            this.cbCancelTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCancelTransaction.FormattingEnabled = true;
            this.cbCancelTransaction.Location = new System.Drawing.Point(20, 43);
            this.cbCancelTransaction.Name = "cbCancelTransaction";
            this.cbCancelTransaction.Size = new System.Drawing.Size(251, 21);
            this.cbCancelTransaction.TabIndex = 1;
            this.cbCancelTransaction.SelectedIndexChanged += new System.EventHandler(this.cbCancelTransaction_SelectedIndexChanged);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Silver;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCancel.Location = new System.Drawing.Point(150, 117);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 41);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // CancelTransactionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbCancelTransaction);
            this.Controls.Add(this.label1);
            this.Name = "CancelTransactionPanel";
            this.Size = new System.Drawing.Size(291, 179);
            this.Load += new System.EventHandler(this.CancelTransactionPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCancelTransaction;
        private BaseControls.ExButton btCancel;
    }
}
