namespace EyeCT4Events
{
    partial class CreateParticipantForm
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
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            this.btnEditParticipant = new System.Windows.Forms.Button();
            this.lblCreateParticipantName = new System.Windows.Forms.Label();
            this.lblCreateParticipantCity = new System.Windows.Forms.Label();
            this.lblCreateParticipantZipCode = new System.Windows.Forms.Label();
            this.lblCreateParticipantEmail = new System.Windows.Forms.Label();
            this.lblCreateParticipantPhoneNumber = new System.Windows.Forms.Label();
            this.lblCreateParticipantDateOfBirth = new System.Windows.Forms.Label();
            this.lblCreateParticipantUsername = new System.Windows.Forms.Label();
            this.lblCreateParticipantPassword = new System.Windows.Forms.Label();
            this.dtpCreateParticipantDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbCreateParticipantName = new System.Windows.Forms.TextBox();
            this.tbCreateParticipantCity = new System.Windows.Forms.TextBox();
            this.tbCreateParticipantZipCode = new System.Windows.Forms.TextBox();
            this.tbCreateParticipantEmail = new System.Windows.Forms.TextBox();
            this.tbCreateParticipantPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCreateParticipantUsername = new System.Windows.Forms.TextBox();
            this.tbCreateParticipantPassword = new System.Windows.Forms.TextBox();
            this.btnCreateParticipantCreateParticipant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(12, 268);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(75, 43);
            this.btnParticipants.TabIndex = 24;
            this.btnParticipants.Text = "Deelnemers";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.Location = new System.Drawing.Point(12, 206);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteParticipant.TabIndex = 23;
            this.btnDeleteParticipant.Text = "Deelnemer Verwijderen";
            this.btnDeleteParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // btnEditParticipant
            // 
            this.btnEditParticipant.Location = new System.Drawing.Point(12, 140);
            this.btnEditParticipant.Name = "btnEditParticipant";
            this.btnEditParticipant.Size = new System.Drawing.Size(75, 43);
            this.btnEditParticipant.TabIndex = 22;
            this.btnEditParticipant.Text = "Deelnemer Aanpassen";
            this.btnEditParticipant.UseVisualStyleBackColor = true;
            this.btnEditParticipant.Click += new System.EventHandler(this.btnEditParticipant_Click);
            // 
            // lblCreateParticipantName
            // 
            this.lblCreateParticipantName.AutoSize = true;
            this.lblCreateParticipantName.Location = new System.Drawing.Point(240, 15);
            this.lblCreateParticipantName.Name = "lblCreateParticipantName";
            this.lblCreateParticipantName.Size = new System.Drawing.Size(38, 13);
            this.lblCreateParticipantName.TabIndex = 25;
            this.lblCreateParticipantName.Text = "Naam:";
            // 
            // lblCreateParticipantCity
            // 
            this.lblCreateParticipantCity.AutoSize = true;
            this.lblCreateParticipantCity.Location = new System.Drawing.Point(240, 51);
            this.lblCreateParticipantCity.Name = "lblCreateParticipantCity";
            this.lblCreateParticipantCity.Size = new System.Drawing.Size(32, 13);
            this.lblCreateParticipantCity.TabIndex = 26;
            this.lblCreateParticipantCity.Text = "Stad:";
            // 
            // lblCreateParticipantZipCode
            // 
            this.lblCreateParticipantZipCode.AutoSize = true;
            this.lblCreateParticipantZipCode.Location = new System.Drawing.Point(238, 91);
            this.lblCreateParticipantZipCode.Name = "lblCreateParticipantZipCode";
            this.lblCreateParticipantZipCode.Size = new System.Drawing.Size(55, 13);
            this.lblCreateParticipantZipCode.TabIndex = 27;
            this.lblCreateParticipantZipCode.Text = "Postcode:";
            // 
            // lblCreateParticipantEmail
            // 
            this.lblCreateParticipantEmail.AutoSize = true;
            this.lblCreateParticipantEmail.Location = new System.Drawing.Point(238, 127);
            this.lblCreateParticipantEmail.Name = "lblCreateParticipantEmail";
            this.lblCreateParticipantEmail.Size = new System.Drawing.Size(65, 13);
            this.lblCreateParticipantEmail.TabIndex = 28;
            this.lblCreateParticipantEmail.Text = "Email Adres:";
            // 
            // lblCreateParticipantPhoneNumber
            // 
            this.lblCreateParticipantPhoneNumber.AutoSize = true;
            this.lblCreateParticipantPhoneNumber.Location = new System.Drawing.Point(238, 161);
            this.lblCreateParticipantPhoneNumber.Name = "lblCreateParticipantPhoneNumber";
            this.lblCreateParticipantPhoneNumber.Size = new System.Drawing.Size(94, 13);
            this.lblCreateParticipantPhoneNumber.TabIndex = 29;
            this.lblCreateParticipantPhoneNumber.Text = "Telefoon Nummer:";
            // 
            // lblCreateParticipantDateOfBirth
            // 
            this.lblCreateParticipantDateOfBirth.AutoSize = true;
            this.lblCreateParticipantDateOfBirth.Location = new System.Drawing.Point(238, 198);
            this.lblCreateParticipantDateOfBirth.Name = "lblCreateParticipantDateOfBirth";
            this.lblCreateParticipantDateOfBirth.Size = new System.Drawing.Size(88, 13);
            this.lblCreateParticipantDateOfBirth.TabIndex = 30;
            this.lblCreateParticipantDateOfBirth.Text = "Geboorte Datum:";
            // 
            // lblCreateParticipantUsername
            // 
            this.lblCreateParticipantUsername.AutoSize = true;
            this.lblCreateParticipantUsername.Location = new System.Drawing.Point(238, 242);
            this.lblCreateParticipantUsername.Name = "lblCreateParticipantUsername";
            this.lblCreateParticipantUsername.Size = new System.Drawing.Size(87, 13);
            this.lblCreateParticipantUsername.TabIndex = 31;
            this.lblCreateParticipantUsername.Text = "Gebruikersnaam:";
            // 
            // lblCreateParticipantPassword
            // 
            this.lblCreateParticipantPassword.AutoSize = true;
            this.lblCreateParticipantPassword.Location = new System.Drawing.Point(238, 278);
            this.lblCreateParticipantPassword.Name = "lblCreateParticipantPassword";
            this.lblCreateParticipantPassword.Size = new System.Drawing.Size(71, 13);
            this.lblCreateParticipantPassword.TabIndex = 32;
            this.lblCreateParticipantPassword.Text = "Wachtwoord:";
            // 
            // dtpCreateParticipantDateOfBirth
            // 
            this.dtpCreateParticipantDateOfBirth.Location = new System.Drawing.Point(338, 198);
            this.dtpCreateParticipantDateOfBirth.Name = "dtpCreateParticipantDateOfBirth";
            this.dtpCreateParticipantDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpCreateParticipantDateOfBirth.TabIndex = 33;
            // 
            // tbCreateParticipantName
            // 
            this.tbCreateParticipantName.Location = new System.Drawing.Point(338, 12);
            this.tbCreateParticipantName.Name = "tbCreateParticipantName";
            this.tbCreateParticipantName.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantName.TabIndex = 34;
            // 
            // tbCreateParticipantCity
            // 
            this.tbCreateParticipantCity.Location = new System.Drawing.Point(338, 48);
            this.tbCreateParticipantCity.Name = "tbCreateParticipantCity";
            this.tbCreateParticipantCity.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantCity.TabIndex = 35;
            // 
            // tbCreateParticipantZipCode
            // 
            this.tbCreateParticipantZipCode.Location = new System.Drawing.Point(338, 88);
            this.tbCreateParticipantZipCode.Name = "tbCreateParticipantZipCode";
            this.tbCreateParticipantZipCode.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantZipCode.TabIndex = 36;
            // 
            // tbCreateParticipantEmail
            // 
            this.tbCreateParticipantEmail.Location = new System.Drawing.Point(338, 124);
            this.tbCreateParticipantEmail.Name = "tbCreateParticipantEmail";
            this.tbCreateParticipantEmail.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantEmail.TabIndex = 37;
            // 
            // tbCreateParticipantPhoneNumber
            // 
            this.tbCreateParticipantPhoneNumber.Location = new System.Drawing.Point(338, 158);
            this.tbCreateParticipantPhoneNumber.Name = "tbCreateParticipantPhoneNumber";
            this.tbCreateParticipantPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantPhoneNumber.TabIndex = 38;
            // 
            // tbCreateParticipantUsername
            // 
            this.tbCreateParticipantUsername.Location = new System.Drawing.Point(338, 239);
            this.tbCreateParticipantUsername.Name = "tbCreateParticipantUsername";
            this.tbCreateParticipantUsername.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantUsername.TabIndex = 39;
            // 
            // tbCreateParticipantPassword
            // 
            this.tbCreateParticipantPassword.Location = new System.Drawing.Point(338, 275);
            this.tbCreateParticipantPassword.Name = "tbCreateParticipantPassword";
            this.tbCreateParticipantPassword.Size = new System.Drawing.Size(200, 20);
            this.tbCreateParticipantPassword.TabIndex = 40;
            // 
            // btnCreateParticipantCreateParticipant
            // 
            this.btnCreateParticipantCreateParticipant.Location = new System.Drawing.Point(463, 301);
            this.btnCreateParticipantCreateParticipant.Name = "btnCreateParticipantCreateParticipant";
            this.btnCreateParticipantCreateParticipant.Size = new System.Drawing.Size(75, 43);
            this.btnCreateParticipantCreateParticipant.TabIndex = 41;
            this.btnCreateParticipantCreateParticipant.Text = "Create Participant";
            this.btnCreateParticipantCreateParticipant.UseVisualStyleBackColor = true;
            this.btnCreateParticipantCreateParticipant.Click += new System.EventHandler(this.btnCreateParticipantCreateParticipant_Click);
            // 
            // CreateParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 408);
            this.Controls.Add(this.btnCreateParticipantCreateParticipant);
            this.Controls.Add(this.tbCreateParticipantPassword);
            this.Controls.Add(this.tbCreateParticipantUsername);
            this.Controls.Add(this.tbCreateParticipantPhoneNumber);
            this.Controls.Add(this.tbCreateParticipantEmail);
            this.Controls.Add(this.tbCreateParticipantZipCode);
            this.Controls.Add(this.tbCreateParticipantCity);
            this.Controls.Add(this.tbCreateParticipantName);
            this.Controls.Add(this.dtpCreateParticipantDateOfBirth);
            this.Controls.Add(this.lblCreateParticipantPassword);
            this.Controls.Add(this.lblCreateParticipantUsername);
            this.Controls.Add(this.lblCreateParticipantDateOfBirth);
            this.Controls.Add(this.lblCreateParticipantPhoneNumber);
            this.Controls.Add(this.lblCreateParticipantEmail);
            this.Controls.Add(this.lblCreateParticipantZipCode);
            this.Controls.Add(this.lblCreateParticipantCity);
            this.Controls.Add(this.lblCreateParticipantName);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnDeleteParticipant);
            this.Controls.Add(this.btnEditParticipant);
            this.Name = "CreateParticipantForm";
            this.Text = "Create Participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.Button btnEditParticipant;
        private System.Windows.Forms.Label lblCreateParticipantName;
        private System.Windows.Forms.Label lblCreateParticipantCity;
        private System.Windows.Forms.Label lblCreateParticipantZipCode;
        private System.Windows.Forms.Label lblCreateParticipantEmail;
        private System.Windows.Forms.Label lblCreateParticipantPhoneNumber;
        private System.Windows.Forms.Label lblCreateParticipantDateOfBirth;
        private System.Windows.Forms.Label lblCreateParticipantUsername;
        private System.Windows.Forms.Label lblCreateParticipantPassword;
        private System.Windows.Forms.DateTimePicker dtpCreateParticipantDateOfBirth;
        private System.Windows.Forms.TextBox tbCreateParticipantName;
        private System.Windows.Forms.TextBox tbCreateParticipantCity;
        private System.Windows.Forms.TextBox tbCreateParticipantZipCode;
        private System.Windows.Forms.TextBox tbCreateParticipantEmail;
        private System.Windows.Forms.TextBox tbCreateParticipantPhoneNumber;
        private System.Windows.Forms.TextBox tbCreateParticipantUsername;
        private System.Windows.Forms.TextBox tbCreateParticipantPassword;
        private System.Windows.Forms.Button btnCreateParticipantCreateParticipant;
    }
}