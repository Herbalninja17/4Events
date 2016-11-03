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
            this.tbLoginEmail.Location = new System.Drawing.Point(101, 12);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(146, 20);
            this.tbLoginEmail.TabIndex = 0;
            // 
            // tbLoginWachtwoord
            // 
            this.tbLoginWachtwoord.Location = new System.Drawing.Point(101, 58);
            this.tbLoginWachtwoord.Name = "tbLoginWachtwoord";
            this.tbLoginWachtwoord.Size = new System.Drawing.Size(145, 20);
            this.tbLoginWachtwoord.TabIndex = 1;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(12, 15);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(69, 13);
            this.lblLoginEmail.TabIndex = 2;
            this.lblLoginEmail.Text = "Email adress:";
            // 
            // lblLoginWachtwoord
            // 
            this.lblLoginWachtwoord.AutoSize = true;
            this.lblLoginWachtwoord.Location = new System.Drawing.Point(12, 61);
            this.lblLoginWachtwoord.Name = "lblLoginWachtwoord";
            this.lblLoginWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lblLoginWachtwoord.TabIndex = 3;
            this.lblLoginWachtwoord.Text = "Wachtwoord:";
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(140, 98);
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
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nog geen account?";
            // 
            // btnLoginCreateAccount
            // 
            this.btnLoginCreateAccount.Location = new System.Drawing.Point(140, 140);
            this.btnLoginCreateAccount.Name = "btnLoginCreateAccount";
            this.btnLoginCreateAccount.Size = new System.Drawing.Size(75, 49);
            this.btnLoginCreateAccount.TabIndex = 6;
            this.btnLoginCreateAccount.Text = "Maak nieuw account aan";
            this.btnLoginCreateAccount.UseVisualStyleBackColor = true;
            this.btnLoginCreateAccount.Click += new System.EventHandler(this.btnLoginCreatAccount_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 204);
            this.Controls.Add(this.btnLoginCreateAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.lblLoginWachtwoord);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.tbLoginWachtwoord);
            this.Controls.Add(this.tbLoginEmail);
            this.Name = "LoginForm";
            this.Text = "Login";
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

