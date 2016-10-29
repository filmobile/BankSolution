namespace BankClient
{
    partial class CurrencyPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUS = new System.Windows.Forms.TextBox();
            this.tbEU = new System.Windows.Forms.TextBox();
            this.tbUA = new System.Windows.Forms.TextBox();
            this.btCurrency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "US";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "UA";
            // 
            // tbUS
            // 
            this.tbUS.Location = new System.Drawing.Point(42, 30);
            this.tbUS.Name = "tbUS";
            this.tbUS.ReadOnly = true;
            this.tbUS.Size = new System.Drawing.Size(57, 20);
            this.tbUS.TabIndex = 4;
            // 
            // tbEU
            // 
            this.tbEU.Location = new System.Drawing.Point(42, 56);
            this.tbEU.Name = "tbEU";
            this.tbEU.ReadOnly = true;
            this.tbEU.Size = new System.Drawing.Size(57, 20);
            this.tbEU.TabIndex = 5;
            // 
            // tbUA
            // 
            this.tbUA.Location = new System.Drawing.Point(42, 79);
            this.tbUA.Name = "tbUA";
            this.tbUA.ReadOnly = true;
            this.tbUA.Size = new System.Drawing.Size(57, 20);
            this.tbUA.TabIndex = 6;
            // 
            // btCurrency
            // 
            this.btCurrency.Location = new System.Drawing.Point(24, 3);
            this.btCurrency.Name = "btCurrency";
            this.btCurrency.Size = new System.Drawing.Size(75, 21);
            this.btCurrency.TabIndex = 7;
            this.btCurrency.Text = "Currency";
            this.btCurrency.UseVisualStyleBackColor = true;
            this.btCurrency.Click += new System.EventHandler(this.btCurrency_Click);
            // 
            // CurrencyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btCurrency);
            this.Controls.Add(this.tbUA);
            this.Controls.Add(this.tbEU);
            this.Controls.Add(this.tbUS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CurrencyPanel";
            this.Size = new System.Drawing.Size(126, 112);
            this.Load += new System.EventHandler(this.CurrencyPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUS;
        private System.Windows.Forms.TextBox tbEU;
        private System.Windows.Forms.TextBox tbUA;
        private System.Windows.Forms.Button btCurrency;
    }
}
