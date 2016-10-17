namespace EyeCT4Events
{
    partial class LoginForm
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
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(82, 68);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(146, 20);
            this.tbLoginUsername.TabIndex = 0;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(82, 114);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(145, 20);
            this.tbLoginPassword.TabIndex = 1;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(12, 71);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(58, 13);
            this.lblLoginUsername.TabIndex = 2;
            this.lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(12, 117);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(56, 13);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password:";
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(140, 154);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLoginLogin.TabIndex = 4;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnLoginCreateAccount
            // 
            this.btnLoginCreateAccount.Location = new System.Drawing.Point(140, 196);
            this.btnLoginCreateAccount.Name = "btnLoginCreateAccount";
            this.btnLoginCreateAccount.Size = new System.Drawing.Size(75, 49);
            this.btnLoginCreateAccount.TabIndex = 6;
            this.btnLoginCreateAccount.Text = "Create new account";
            this.btnLoginCreateAccount.UseVisualStyleBackColor = true;
            this.btnLoginCreateAccount.Click += new System.EventHandler(this.btnLoginCreatAccount_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 252);
            this.Controls.Add(this.btnLoginCreateAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginCreateAccount;
    }
}

