namespace EyeCT4Events
{
    partial class CreateEventForm
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
            this.lblCreateEventName = new System.Windows.Forms.Label();
            this.lblCreateEventStreet = new System.Windows.Forms.Label();
            this.lblCreateEventCity = new System.Windows.Forms.Label();
            this.lblCreateEventZipcode = new System.Windows.Forms.Label();
            this.lblCreateEventProvince = new System.Windows.Forms.Label();
            this.lblCreateEventBeginDate = new System.Windows.Forms.Label();
            this.lblCreateEventEndDate = new System.Windows.Forms.Label();
            this.lblCreateEventCapacity = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbCreateEventName = new System.Windows.Forms.TextBox();
            this.tbCreateEventStreet = new System.Windows.Forms.TextBox();
            this.tbCreateEventCity = new System.Windows.Forms.TextBox();
            this.tbCreateEventZipCode = new System.Windows.Forms.TextBox();
            this.tbCreateEventProvince = new System.Windows.Forms.TextBox();
            this.tbCreateEventCapacity = new System.Windows.Forms.TextBox();
            this.btnCreateEventCreateEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateEventName
            // 
            this.lblCreateEventName.AutoSize = true;
            this.lblCreateEventName.Location = new System.Drawing.Point(226, 15);
            this.lblCreateEventName.Name = "lblCreateEventName";
            this.lblCreateEventName.Size = new System.Drawing.Size(95, 13);
            this.lblCreateEventName.TabIndex = 0;
            this.lblCreateEventName.Text = "Evenement Naam:";
            // 
            // lblCreateEventStreet
            // 
            this.lblCreateEventStreet.AutoSize = true;
            this.lblCreateEventStreet.Location = new System.Drawing.Point(226, 57);
            this.lblCreateEventStreet.Name = "lblCreateEventStreet";
            this.lblCreateEventStreet.Size = new System.Drawing.Size(38, 13);
            this.lblCreateEventStreet.TabIndex = 1;
            this.lblCreateEventStreet.Text = "Straat:";
            // 
            // lblCreateEventCity
            // 
            this.lblCreateEventCity.AutoSize = true;
            this.lblCreateEventCity.Location = new System.Drawing.Point(226, 99);
            this.lblCreateEventCity.Name = "lblCreateEventCity";
            this.lblCreateEventCity.Size = new System.Drawing.Size(32, 13);
            this.lblCreateEventCity.TabIndex = 2;
            this.lblCreateEventCity.Text = "Stad:";
            // 
            // lblCreateEventZipcode
            // 
            this.lblCreateEventZipcode.AutoSize = true;
            this.lblCreateEventZipcode.Location = new System.Drawing.Point(226, 139);
            this.lblCreateEventZipcode.Name = "lblCreateEventZipcode";
            this.lblCreateEventZipcode.Size = new System.Drawing.Size(55, 13);
            this.lblCreateEventZipcode.TabIndex = 3;
            this.lblCreateEventZipcode.Text = "Postcode:";
            // 
            // lblCreateEventProvince
            // 
            this.lblCreateEventProvince.AutoSize = true;
            this.lblCreateEventProvince.Location = new System.Drawing.Point(226, 182);
            this.lblCreateEventProvince.Name = "lblCreateEventProvince";
            this.lblCreateEventProvince.Size = new System.Drawing.Size(54, 13);
            this.lblCreateEventProvince.TabIndex = 4;
            this.lblCreateEventProvince.Text = "Provincie:";
            // 
            // lblCreateEventBeginDate
            // 
            this.lblCreateEventBeginDate.AutoSize = true;
            this.lblCreateEventBeginDate.Location = new System.Drawing.Point(226, 220);
            this.lblCreateEventBeginDate.Name = "lblCreateEventBeginDate";
            this.lblCreateEventBeginDate.Size = new System.Drawing.Size(71, 13);
            this.lblCreateEventBeginDate.TabIndex = 5;
            this.lblCreateEventBeginDate.Text = "Begin Datum:";
            // 
            // lblCreateEventEndDate
            // 
            this.lblCreateEventEndDate.AutoSize = true;
            this.lblCreateEventEndDate.Location = new System.Drawing.Point(226, 260);
            this.lblCreateEventEndDate.Name = "lblCreateEventEndDate";
            this.lblCreateEventEndDate.Size = new System.Drawing.Size(65, 13);
            this.lblCreateEventEndDate.TabIndex = 6;
            this.lblCreateEventEndDate.Text = "Eind Datum:";
            // 
            // lblCreateEventCapacity
            // 
            this.lblCreateEventCapacity.AutoSize = true;
            this.lblCreateEventCapacity.Location = new System.Drawing.Point(226, 293);
            this.lblCreateEventCapacity.Name = "lblCreateEventCapacity";
            this.lblCreateEventCapacity.Size = new System.Drawing.Size(92, 13);
            this.lblCreateEventCapacity.TabIndex = 7;
            this.lblCreateEventCapacity.Text = "Max. Deelnemers:";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(343, 214);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDate.TabIndex = 8;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(343, 254);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // tbCreateEventName
            // 
            this.tbCreateEventName.Location = new System.Drawing.Point(343, 12);
            this.tbCreateEventName.Name = "tbCreateEventName";
            this.tbCreateEventName.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventName.TabIndex = 10;
            // 
            // tbCreateEventStreet
            // 
            this.tbCreateEventStreet.Location = new System.Drawing.Point(343, 54);
            this.tbCreateEventStreet.Name = "tbCreateEventStreet";
            this.tbCreateEventStreet.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventStreet.TabIndex = 11;
            // 
            // tbCreateEventCity
            // 
            this.tbCreateEventCity.Location = new System.Drawing.Point(343, 96);
            this.tbCreateEventCity.Name = "tbCreateEventCity";
            this.tbCreateEventCity.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventCity.TabIndex = 12;
            // 
            // tbCreateEventZipCode
            // 
            this.tbCreateEventZipCode.Location = new System.Drawing.Point(343, 136);
            this.tbCreateEventZipCode.Name = "tbCreateEventZipCode";
            this.tbCreateEventZipCode.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventZipCode.TabIndex = 13;
            // 
            // tbCreateEventProvince
            // 
            this.tbCreateEventProvince.Location = new System.Drawing.Point(343, 179);
            this.tbCreateEventProvince.Name = "tbCreateEventProvince";
            this.tbCreateEventProvince.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventProvince.TabIndex = 14;
            // 
            // tbCreateEventCapacity
            // 
            this.tbCreateEventCapacity.Location = new System.Drawing.Point(343, 290);
            this.tbCreateEventCapacity.Name = "tbCreateEventCapacity";
            this.tbCreateEventCapacity.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventCapacity.TabIndex = 15;
            // 
            // btnCreateEventCreateEvent
            // 
            this.btnCreateEventCreateEvent.Location = new System.Drawing.Point(468, 316);
            this.btnCreateEventCreateEvent.Name = "btnCreateEventCreateEvent";
            this.btnCreateEventCreateEvent.Size = new System.Drawing.Size(75, 40);
            this.btnCreateEventCreateEvent.TabIndex = 16;
            this.btnCreateEventCreateEvent.Text = "Evenement Aanmaken";
            this.btnCreateEventCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEventCreateEvent.Click += new System.EventHandler(this.btnCreateEventCreateEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Location = new System.Drawing.Point(12, 139);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(75, 43);
            this.btnEditEvent.TabIndex = 18;
            this.btnEditEvent.Text = "Evenement Aanpassen";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(12, 205);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteEvent.TabIndex = 19;
            this.btnDeleteEvent.Text = "Evenement Verwijderen";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(12, 267);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(75, 43);
            this.btnParticipants.TabIndex = 20;
            this.btnParticipants.Text = "Deelnemers";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 386);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnCreateEventCreateEvent);
            this.Controls.Add(this.tbCreateEventCapacity);
            this.Controls.Add(this.tbCreateEventProvince);
            this.Controls.Add(this.tbCreateEventZipCode);
            this.Controls.Add(this.tbCreateEventCity);
            this.Controls.Add(this.tbCreateEventStreet);
            this.Controls.Add(this.tbCreateEventName);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.lblCreateEventCapacity);
            this.Controls.Add(this.lblCreateEventEndDate);
            this.Controls.Add(this.lblCreateEventBeginDate);
            this.Controls.Add(this.lblCreateEventProvince);
            this.Controls.Add(this.lblCreateEventZipcode);
            this.Controls.Add(this.lblCreateEventCity);
            this.Controls.Add(this.lblCreateEventStreet);
            this.Controls.Add(this.lblCreateEventName);
            this.Name = "CreateEventForm";
            this.Text = "Create Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateEventName;
        private System.Windows.Forms.Label lblCreateEventStreet;
        private System.Windows.Forms.Label lblCreateEventCity;
        private System.Windows.Forms.Label lblCreateEventZipcode;
        private System.Windows.Forms.Label lblCreateEventProvince;
        private System.Windows.Forms.Label lblCreateEventBeginDate;
        private System.Windows.Forms.Label lblCreateEventEndDate;
        private System.Windows.Forms.Label lblCreateEventCapacity;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbCreateEventName;
        private System.Windows.Forms.TextBox tbCreateEventStreet;
        private System.Windows.Forms.TextBox tbCreateEventCity;
        private System.Windows.Forms.TextBox tbCreateEventZipCode;
        private System.Windows.Forms.TextBox tbCreateEventProvince;
        private System.Windows.Forms.TextBox tbCreateEventCapacity;
        private System.Windows.Forms.Button btnCreateEventCreateEvent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnParticipants;
    }
}