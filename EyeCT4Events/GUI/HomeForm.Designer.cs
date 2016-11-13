namespace EyeCT4Events.GUI
{
    partial class HomeForm
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
            this.btnGoToReservation = new System.Windows.Forms.Button();
            this.btnGoToEvent = new System.Windows.Forms.Button();
            this.btnGoToSocialMedia = new System.Windows.Forms.Button();
            this.btnGoToLease = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToReservation
            // 
            this.btnGoToReservation.Location = new System.Drawing.Point(13, 13);
            this.btnGoToReservation.Name = "btnGoToReservation";
            this.btnGoToReservation.Size = new System.Drawing.Size(109, 51);
            this.btnGoToReservation.TabIndex = 0;
            this.btnGoToReservation.Text = "Reserveringen";
            this.btnGoToReservation.UseVisualStyleBackColor = true;
            this.btnGoToReservation.Click += new System.EventHandler(this.btnGoToReservation_Click);
            // 
            // btnGoToEvent
            // 
            this.btnGoToEvent.Location = new System.Drawing.Point(13, 70);
            this.btnGoToEvent.Name = "btnGoToEvent";
            this.btnGoToEvent.Size = new System.Drawing.Size(109, 51);
            this.btnGoToEvent.TabIndex = 1;
            this.btnGoToEvent.Text = "Evenement";
            this.btnGoToEvent.UseVisualStyleBackColor = true;
            this.btnGoToEvent.Click += new System.EventHandler(this.btnGoToEvent_Click);
            // 
            // btnGoToSocialMedia
            // 
            this.btnGoToSocialMedia.Location = new System.Drawing.Point(13, 127);
            this.btnGoToSocialMedia.Name = "btnGoToSocialMedia";
            this.btnGoToSocialMedia.Size = new System.Drawing.Size(109, 51);
            this.btnGoToSocialMedia.TabIndex = 2;
            this.btnGoToSocialMedia.Text = "Social Media";
            this.btnGoToSocialMedia.UseVisualStyleBackColor = true;
            this.btnGoToSocialMedia.Click += new System.EventHandler(this.btnGoToSocialMedia_Click);
            // 
            // btnGoToLease
            // 
            this.btnGoToLease.Location = new System.Drawing.Point(13, 184);
            this.btnGoToLease.Name = "btnGoToLease";
            this.btnGoToLease.Size = new System.Drawing.Size(109, 51);
            this.btnGoToLease.TabIndex = 3;
            this.btnGoToLease.Text = "Verhuur";
            this.btnGoToLease.UseVisualStyleBackColor = true;
            this.btnGoToLease.Click += new System.EventHandler(this.btnGoToLease_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(13, 241);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(109, 51);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Uitloggen";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::EyeCT4Events.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(128, 70);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(461, 222);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welkom:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(204, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 20);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "(Inlognaam)";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(480, 13);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(109, 51);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 303);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGoToLease);
            this.Controls.Add(this.btnGoToSocialMedia);
            this.Controls.Add(this.btnGoToEvent);
            this.Controls.Add(this.btnGoToReservation);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToReservation;
        private System.Windows.Forms.Button btnGoToEvent;
        private System.Windows.Forms.Button btnGoToSocialMedia;
        private System.Windows.Forms.Button btnGoToLease;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAccount;
    }
}