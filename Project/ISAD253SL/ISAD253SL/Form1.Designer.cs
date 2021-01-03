namespace ISAD253SL
{
    partial class frmLogin
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLOGUsername = new System.Windows.Forms.TextBox();
            this.txtLOGPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linklblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(179, 119);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(179, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtLOGUsername
            // 
            this.txtLOGUsername.Location = new System.Drawing.Point(342, 113);
            this.txtLOGUsername.Name = "txtLOGUsername";
            this.txtLOGUsername.Size = new System.Drawing.Size(100, 22);
            this.txtLOGUsername.TabIndex = 2;
            // 
            // txtLOGPassword
            // 
            this.txtLOGPassword.Location = new System.Drawing.Point(342, 168);
            this.txtLOGPassword.Name = "txtLOGPassword";
            this.txtLOGPassword.Size = new System.Drawing.Size(100, 22);
            this.txtLOGPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(353, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linklblCreateAccount
            // 
            this.linklblCreateAccount.AutoSize = true;
            this.linklblCreateAccount.Location = new System.Drawing.Point(654, 27);
            this.linklblCreateAccount.Name = "linklblCreateAccount";
            this.linklblCreateAccount.Size = new System.Drawing.Size(105, 17);
            this.linklblCreateAccount.TabIndex = 5;
            this.linklblCreateAccount.TabStop = true;
            this.linklblCreateAccount.Text = "Create Account";
            this.linklblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linklblCreateAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLOGPassword);
            this.Controls.Add(this.txtLOGUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLOGUsername;
        private System.Windows.Forms.TextBox txtLOGPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linklblCreateAccount;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

