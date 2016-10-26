namespace BankClient
{
    partial class AuthorizationForm
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
            this.authorizePanel2 = new BankClient.AuthorizePanel();
            this.SuspendLayout();
            // 
            // authorizePanel2
            // 
            this.authorizePanel2.Location = new System.Drawing.Point(39, 12);
            this.authorizePanel2.Name = "authorizePanel2";
            this.authorizePanel2.Size = new System.Drawing.Size(384, 271);
            this.authorizePanel2.TabIndex = 0;
            this.authorizePanel2.LoginSuccessfull += new System.EventHandler(this.authorizePanel2_LoginSuccessfull);
            // 
            // AuthorizationForm
            // 
            this.ClientSize = new System.Drawing.Size(487, 298);
            this.Controls.Add(this.authorizePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private AuthorizePanel authorizePanel1;
        private System.Windows.Forms.Button btEnterLogPass;
        private AuthorizePanel authorizePanel2;
    }
}

