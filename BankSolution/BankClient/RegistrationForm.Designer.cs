﻿namespace BankClient
{
    partial class RegistrationForm
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
            this.registrPanel1 = new BankClient.RegistrPanel();
            this.SuspendLayout();
            // 
            // registrPanel1
            // 
            this.registrPanel1.Location = new System.Drawing.Point(53, 12);
            this.registrPanel1.Name = "registrPanel1";
            this.registrPanel1.Size = new System.Drawing.Size(409, 278);
            this.registrPanel1.TabIndex = 0;
            this.registrPanel1.LoginSuccessfull += new System.EventHandler(this.registrPanel1_LoginSuccessfull);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 314);
            this.Controls.Add(this.registrPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RegistrPanel registrPanel1;
    }
}