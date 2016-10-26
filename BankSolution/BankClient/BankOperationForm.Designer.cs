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
            this.bnClientData = new System.Windows.Forms.Button();
            this.bankOperationPanel1 = new BankClient.BankOperationPanel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // bnClientData
            // 
            this.bnClientData.Location = new System.Drawing.Point(356, 12);
            this.bnClientData.Name = "bnClientData";
            this.bnClientData.Size = new System.Drawing.Size(75, 23);
            this.bnClientData.TabIndex = 1;
            this.bnClientData.Text = "ClientData";
            this.bnClientData.UseVisualStyleBackColor = true;
            this.bnClientData.Click += new System.EventHandler(this.bnClientData_Click);
            // 
            // bankOperationPanel1
            // 
            this.bankOperationPanel1.Location = new System.Drawing.Point(308, 53);
            this.bankOperationPanel1.Name = "bankOperationPanel1";
            this.bankOperationPanel1.Size = new System.Drawing.Size(627, 332);
            this.bankOperationPanel1.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(4, 38);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(327, 184);
            this.dgvData.TabIndex = 2;
            // 
            // BankOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 440);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.bnClientData);
            this.Controls.Add(this.bankOperationPanel1);
            this.Name = "BankOperationForm";
            this.Text = "BankOperationForm";
            this.Load += new System.EventHandler(this.BankOperationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BankOperationPanel bankOperationPanel1;
        private System.Windows.Forms.Button bnClientData;
        private System.Windows.Forms.DataGridView dgvData;
    }
}