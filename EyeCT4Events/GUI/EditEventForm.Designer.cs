namespace EyeCT4Events
{
    partial class EditEventForm
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
            this.btnEditEventSearch = new System.Windows.Forms.Button();
            this.lblEditSearchEventName = new System.Windows.Forms.Label();
            this.tbSearchEditEventName = new System.Windows.Forms.TextBox();
            this.lbEditEvent = new System.Windows.Forms.ListBox();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnEditEventEditEvent = new System.Windows.Forms.Button();
            this.tbEditEventCapacity = new System.Windows.Forms.TextBox();
            this.tbEditEventZipCode = new System.Windows.Forms.TextBox();
            this.tbEditEventCity = new System.Windows.Forms.TextBox();
            this.tbEditEventStreet = new System.Windows.Forms.TextBox();
            this.tbEditEventName = new System.Windows.Forms.TextBox();
            this.dtpEditEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEditBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblEditEventCapacity = new System.Windows.Forms.Label();
            this.lblEditEventEndDate = new System.Windows.Forms.Label();
            this.lblEditEventBeginDate = new System.Windows.Forms.Label();
            this.lblEditEventZipcode = new System.Windows.Forms.Label();
            this.lblEditEventCity = new System.Windows.Forms.Label();
            this.lblEditEventStreet = new System.Windows.Forms.Label();
            this.lblEditEventName = new System.Windows.Forms.Label();
            this.btnEditEventSelectEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditEventSearch
            // 
            this.btnEditEventSearch.Location = new System.Drawing.Point(418, 35);
            this.btnEditEventSearch.Name = "btnEditEventSearch";
            this.btnEditEventSearch.Size = new System.Drawing.Size(75, 42);
            this.btnEditEventSearch.TabIndex = 35;
            this.btnEditEventSearch.Text = "Zoeken";
            this.btnEditEventSearch.UseVisualStyleBackColor = true;
            this.btnEditEventSearch.Click += new System.EventHandler(this.btnEditEventSearch_Click);
            // 
            // lblEditSearchEventName
            // 
            this.lblEditSearchEventName.AutoSize = true;
            this.lblEditSearchEventName.Location = new System.Drawing.Point(167, 12);
            this.lblEditSearchEventName.Name = "lblEditSearchEventName";
            this.lblEditSearchEventName.Size = new System.Drawing.Size(95, 13);
            this.lblEditSearchEventName.TabIndex = 34;
            this.lblEditSearchEventName.Text = "Evenement Naam:";
            // 
            // tbSearchEditEventName
            // 
            this.tbSearchEditEventName.Location = new System.Drawing.Point(268, 9);
            this.tbSearchEditEventName.Name = "tbSearchEditEventName";
            this.tbSearchEditEventName.Size = new System.Drawing.Size(225, 20);
            this.tbSearchEditEventName.TabIndex = 33;
            // 
            // lbEditEvent
            // 
            this.lbEditEvent.FormattingEnabled = true;
            this.lbEditEvent.Location = new System.Drawing.Point(170, 83);
            this.lbEditEvent.Name = "lbEditEvent";
            this.lbEditEvent.Size = new System.Drawing.Size(323, 225);
            this.lbEditEvent.TabIndex = 32;
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(12, 265);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(75, 43);
            this.btnParticipants.TabIndex = 31;
            this.btnParticipants.Text = "Deelnemers";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(12, 211);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteEvent.TabIndex = 30;
            this.btnDeleteEvent.Text = "Evenement Verwijderen";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(12, 156);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(75, 43);
            this.btnCreateEvent.TabIndex = 29;
            this.btnCreateEvent.Text = "Evenement Aanmaken";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnEditEventEditEvent
            // 
            this.btnEditEventEditEvent.Location = new System.Drawing.Point(757, 313);
            this.btnEditEventEditEvent.Name = "btnEditEventEditEvent";
            this.btnEditEventEditEvent.Size = new System.Drawing.Size(75, 40);
            this.btnEditEventEditEvent.TabIndex = 52;
            this.btnEditEventEditEvent.Text = "Evenement Aanpassen";
            this.btnEditEventEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEventEditEvent.Click += new System.EventHandler(this.btnEditEventEditEvent_Click);
            // 
            // tbEditEventCapacity
            // 
            this.tbEditEventCapacity.Location = new System.Drawing.Point(632, 287);
            this.tbEditEventCapacity.Name = "tbEditEventCapacity";
            this.tbEditEventCapacity.Size = new System.Drawing.Size(200, 20);
            this.tbEditEventCapacity.TabIndex = 51;
            // 
            // tbEditEventZipCode
            // 
            this.tbEditEventZipCode.Location = new System.Drawing.Point(632, 133);
            this.tbEditEventZipCode.Name = "tbEditEventZipCode";
            this.tbEditEventZipCode.ReadOnly = true;
            this.tbEditEventZipCode.Size = new System.Drawing.Size(200, 20);
            this.tbEditEventZipCode.TabIndex = 49;
            // 
            // tbEditEventCity
            // 
            this.tbEditEventCity.Location = new System.Drawing.Point(632, 93);
            this.tbEditEventCity.Name = "tbEditEventCity";
            this.tbEditEventCity.ReadOnly = true;
            this.tbEditEventCity.Size = new System.Drawing.Size(200, 20);
            this.tbEditEventCity.TabIndex = 48;
            // 
            // tbEditEventStreet
            // 
            this.tbEditEventStreet.Location = new System.Drawing.Point(632, 51);
            this.tbEditEventStreet.Name = "tbEditEventStreet";
            this.tbEditEventStreet.ReadOnly = true;
            this.tbEditEventStreet.Size = new System.Drawing.Size(200, 20);
            this.tbEditEventStreet.TabIndex = 47;
            // 
            // tbEditEventName
            // 
            this.tbEditEventName.Location = new System.Drawing.Point(632, 9);
            this.tbEditEventName.Name = "tbEditEventName";
            this.tbEditEventName.Size = new System.Drawing.Size(200, 20);
            this.tbEditEventName.TabIndex = 46;
            // 
            // dtpEditEndDate
            // 
            this.dtpEditEndDate.Location = new System.Drawing.Point(632, 251);
            this.dtpEditEndDate.Name = "dtpEditEndDate";
            this.dtpEditEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEditEndDate.TabIndex = 45;
            // 
            // dtpEditBeginDate
            // 
            this.dtpEditBeginDate.Location = new System.Drawing.Point(632, 211);
            this.dtpEditBeginDate.Name = "dtpEditBeginDate";
            this.dtpEditBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEditBeginDate.TabIndex = 44;
            // 
            // lblEditEventCapacity
            // 
            this.lblEditEventCapacity.AutoSize = true;
            this.lblEditEventCapacity.Location = new System.Drawing.Point(515, 290);
            this.lblEditEventCapacity.Name = "lblEditEventCapacity";
            this.lblEditEventCapacity.Size = new System.Drawing.Size(92, 13);
            this.lblEditEventCapacity.TabIndex = 43;
            this.lblEditEventCapacity.Text = "Max. Deelnemers:";
            // 
            // lblEditEventEndDate
            // 
            this.lblEditEventEndDate.AutoSize = true;
            this.lblEditEventEndDate.Location = new System.Drawing.Point(515, 257);
            this.lblEditEventEndDate.Name = "lblEditEventEndDate";
            this.lblEditEventEndDate.Size = new System.Drawing.Size(65, 13);
            this.lblEditEventEndDate.TabIndex = 42;
            this.lblEditEventEndDate.Text = "Eind Datum:";
            // 
            // lblEditEventBeginDate
            // 
            this.lblEditEventBeginDate.AutoSize = true;
            this.lblEditEventBeginDate.Location = new System.Drawing.Point(515, 217);
            this.lblEditEventBeginDate.Name = "lblEditEventBeginDate";
            this.lblEditEventBeginDate.Size = new System.Drawing.Size(71, 13);
            this.lblEditEventBeginDate.TabIndex = 41;
            this.lblEditEventBeginDate.Text = "Begin Datum:";
            // 
            // lblEditEventZipcode
            // 
            this.lblEditEventZipcode.AutoSize = true;
            this.lblEditEventZipcode.Location = new System.Drawing.Point(515, 136);
            this.lblEditEventZipcode.Name = "lblEditEventZipcode";
            this.lblEditEventZipcode.Size = new System.Drawing.Size(55, 13);
            this.lblEditEventZipcode.TabIndex = 39;
            this.lblEditEventZipcode.Text = "Postcode:";
            // 
            // lblEditEventCity
            // 
            this.lblEditEventCity.AutoSize = true;
            this.lblEditEventCity.Location = new System.Drawing.Point(515, 96);
            this.lblEditEventCity.Name = "lblEditEventCity";
            this.lblEditEventCity.Size = new System.Drawing.Size(32, 13);
            this.lblEditEventCity.TabIndex = 38;
            this.lblEditEventCity.Text = "Stad:";
            // 
            // lblEditEventStreet
            // 
            this.lblEditEventStreet.AutoSize = true;
            this.lblEditEventStreet.Location = new System.Drawing.Point(515, 54);
            this.lblEditEventStreet.Name = "lblEditEventStreet";
            this.lblEditEventStreet.Size = new System.Drawing.Size(38, 13);
            this.lblEditEventStreet.TabIndex = 37;
            this.lblEditEventStreet.Text = "Straat:";
            // 
            // lblEditEventName
            // 
            this.lblEditEventName.AutoSize = true;
            this.lblEditEventName.Location = new System.Drawing.Point(515, 12);
            this.lblEditEventName.Name = "lblEditEventName";
            this.lblEditEventName.Size = new System.Drawing.Size(95, 13);
            this.lblEditEventName.TabIndex = 36;
            this.lblEditEventName.Text = "Evenement Naam:";
            // 
            // btnEditEventSelectEvent
            // 
            this.btnEditEventSelectEvent.Location = new System.Drawing.Point(418, 318);
            this.btnEditEventSelectEvent.Name = "btnEditEventSelectEvent";
            this.btnEditEventSelectEvent.Size = new System.Drawing.Size(75, 40);
            this.btnEditEventSelectEvent.TabIndex = 53;
            this.btnEditEventSelectEvent.Text = "Evenement Selecteren";
            this.btnEditEventSelectEvent.UseVisualStyleBackColor = true;
            this.btnEditEventSelectEvent.Click += new System.EventHandler(this.btnEditEventSelectEvent_Click);
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 370);
            this.Controls.Add(this.btnEditEventSelectEvent);
            this.Controls.Add(this.btnEditEventEditEvent);
            this.Controls.Add(this.tbEditEventCapacity);
            this.Controls.Add(this.tbEditEventZipCode);
            this.Controls.Add(this.tbEditEventCity);
            this.Controls.Add(this.tbEditEventStreet);
            this.Controls.Add(this.tbEditEventName);
            this.Controls.Add(this.dtpEditEndDate);
            this.Controls.Add(this.dtpEditBeginDate);
            this.Controls.Add(this.lblEditEventCapacity);
            this.Controls.Add(this.lblEditEventEndDate);
            this.Controls.Add(this.lblEditEventBeginDate);
            this.Controls.Add(this.lblEditEventZipcode);
            this.Controls.Add(this.lblEditEventCity);
            this.Controls.Add(this.lblEditEventStreet);
            this.Controls.Add(this.lblEditEventName);
            this.Controls.Add(this.btnEditEventSearch);
            this.Controls.Add(this.lblEditSearchEventName);
            this.Controls.Add(this.tbSearchEditEventName);
            this.Controls.Add(this.lbEditEvent);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Name = "EditEventForm";
            this.Text = "Edit Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditEventSearch;
        private System.Windows.Forms.Label lblEditSearchEventName;
        private System.Windows.Forms.TextBox tbSearchEditEventName;
        private System.Windows.Forms.ListBox lbEditEvent;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnEditEventEditEvent;
        private System.Windows.Forms.TextBox tbEditEventCapacity;
        private System.Windows.Forms.TextBox tbEditEventZipCode;
        private System.Windows.Forms.TextBox tbEditEventCity;
        private System.Windows.Forms.TextBox tbEditEventStreet;
        private System.Windows.Forms.TextBox tbEditEventName;
        private System.Windows.Forms.DateTimePicker dtpEditEndDate;
        private System.Windows.Forms.DateTimePicker dtpEditBeginDate;
        private System.Windows.Forms.Label lblEditEventCapacity;
        private System.Windows.Forms.Label lblEditEventEndDate;
        private System.Windows.Forms.Label lblEditEventBeginDate;
        private System.Windows.Forms.Label lblEditEventZipcode;
        private System.Windows.Forms.Label lblEditEventCity;
        private System.Windows.Forms.Label lblEditEventStreet;
        private System.Windows.Forms.Label lblEditEventName;
        private System.Windows.Forms.Button btnEditEventSelectEvent;
    }
}