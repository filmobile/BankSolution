using BankClient.BaseControls;

namespace BankClient.Controls
{
    partial class AuthorizePanel
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
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.btEnter = new BankClient.BaseControls.ExButton();
            this.btRegistration = new BankClient.BaseControls.ExButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserLogin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserPassword";
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Location = new System.Drawing.Point(125, 31);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(100, 20);
            this.tbUserLogin.TabIndex = 2;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(125, 63);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(100, 20);
            this.tbUserPassword.TabIndex = 3;
            this.tbUserPassword.UseSystemPasswordChar = true;
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.Silver;
            this.btEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnter.Location = new System.Drawing.Point(161, 124);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(110, 40);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Enter";
            this.btEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btRegistration
            // 
            this.btRegistration.BackColor = System.Drawing.Color.Silver;
            this.btRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistration.Location = new System.Drawing.Point(21, 124);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(110, 40);
            this.btRegistration.TabIndex = 5;
            this.btRegistration.Text = "Registration";
            this.btRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // AuthorizePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUserPassword);
            this.Controls.Add(this.tbUserLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(295, 182);
            this.Name = "AuthorizePanel";
            this.Size = new System.Drawing.Size(295, 182);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.TextBox tbUserPassword;
        private ExButton btEnter;
        private ExButton btRegistration;
    }
}
