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
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.tbLoginWachtwoord = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblLoginWachtwoord = new System.Windows.Forms.Label();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Location = new System.Drawing.Point(202, 23);
            this.tbLoginEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(288, 31);
            this.tbLoginEmail.TabIndex = 0;
            // 
            // tbLoginWachtwoord
            // 
            this.tbLoginWachtwoord.Location = new System.Drawing.Point(202, 112);
            this.tbLoginWachtwoord.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbLoginWachtwoord.Name = "tbLoginWachtwoord";
            this.tbLoginWachtwoord.Size = new System.Drawing.Size(286, 31);
            this.tbLoginWachtwoord.TabIndex = 1;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(24, 29);
            this.lblLoginEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(142, 25);
            this.lblLoginEmail.TabIndex = 2;
            this.lblLoginEmail.Text = "Email adress:";
            // 
            // lblLoginWachtwoord
            // 
            this.lblLoginWachtwoord.AutoSize = true;
            this.lblLoginWachtwoord.Location = new System.Drawing.Point(24, 117);
            this.lblLoginWachtwoord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoginWachtwoord.Name = "lblLoginWachtwoord";
            this.lblLoginWachtwoord.Size = new System.Drawing.Size(137, 25);
            this.lblLoginWachtwoord.TabIndex = 3;
            this.lblLoginWachtwoord.Text = "Wachtwoord:";
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(280, 188);
            this.btnLoginLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(150, 44);
            this.btnLoginLogin.TabIndex = 4;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nog geen account?";
            // 
            // btnLoginCreateAccount
            // 
            this.btnLoginCreateAccount.Location = new System.Drawing.Point(280, 269);
            this.btnLoginCreateAccount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoginCreateAccount.Name = "btnLoginCreateAccount";
            this.btnLoginCreateAccount.Size = new System.Drawing.Size(150, 94);
            this.btnLoginCreateAccount.TabIndex = 6;
            this.btnLoginCreateAccount.Text = "Maak nieuw account aan";
            this.btnLoginCreateAccount.UseVisualStyleBackColor = true;
            this.btnLoginCreateAccount.Click += new System.EventHandler(this.btnLoginCreatAccount_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 392);
            this.Controls.Add(this.btnLoginCreateAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.lblLoginWachtwoord);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.tbLoginWachtwoord);
            this.Controls.Add(this.tbLoginEmail);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.TextBox tbLoginWachtwoord;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblLoginWachtwoord;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginCreateAccount;
    }
}

