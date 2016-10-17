namespace EyeCT4Events
{
    partial class MakeReservationForm
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
            this.lbReservationEvents = new System.Windows.Forms.ListBox();
            this.btnReservationsLocation = new System.Windows.Forms.Button();
            this.btnReservationsReservations = new System.Windows.Forms.Button();
            this.btnReservationsMakeReservation = new System.Windows.Forms.Button();
            this.lbReservationParticipants = new System.Windows.Forms.ListBox();
            this.btnReservationSearchParticipant = new System.Windows.Forms.Button();
            this.btnReservationAddParticipant = new System.Windows.Forms.Button();
            this.lblReservationBeginDate = new System.Windows.Forms.Label();
            this.lblReservationEndDate = new System.Windows.Forms.Label();
            this.dtpReservationBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReservationEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbReservationSearchParticipant = new System.Windows.Forms.TextBox();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReservationEvents
            // 
            this.lbReservationEvents.FormattingEnabled = true;
            this.lbReservationEvents.Location = new System.Drawing.Point(12, 7);
            this.lbReservationEvents.Name = "lbReservationEvents";
            this.lbReservationEvents.Size = new System.Drawing.Size(182, 368);
            this.lbReservationEvents.TabIndex = 0;
            // 
            // btnReservationsLocation
            // 
            this.btnReservationsLocation.Location = new System.Drawing.Point(232, 12);
            this.btnReservationsLocation.Name = "btnReservationsLocation";
            this.btnReservationsLocation.Size = new System.Drawing.Size(75, 35);
            this.btnReservationsLocation.TabIndex = 1;
            this.btnReservationsLocation.Text = "Choose Location";
            this.btnReservationsLocation.UseVisualStyleBackColor = true;
            this.btnReservationsLocation.Click += new System.EventHandler(this.btnReservationsLocation_Click);
            // 
            // btnReservationsReservations
            // 
            this.btnReservationsReservations.Location = new System.Drawing.Point(366, 12);
            this.btnReservationsReservations.Name = "btnReservationsReservations";
            this.btnReservationsReservations.Size = new System.Drawing.Size(80, 35);
            this.btnReservationsReservations.TabIndex = 2;
            this.btnReservationsReservations.Text = "Reservations";
            this.btnReservationsReservations.UseVisualStyleBackColor = true;
            this.btnReservationsReservations.Click += new System.EventHandler(this.btnReservationsReservations_Click);
            // 
            // btnReservationsMakeReservation
            // 
            this.btnReservationsMakeReservation.Location = new System.Drawing.Point(504, 12);
            this.btnReservationsMakeReservation.Name = "btnReservationsMakeReservation";
            this.btnReservationsMakeReservation.Size = new System.Drawing.Size(75, 35);
            this.btnReservationsMakeReservation.TabIndex = 3;
            this.btnReservationsMakeReservation.Text = "Make Reservation";
            this.btnReservationsMakeReservation.UseVisualStyleBackColor = true;
            this.btnReservationsMakeReservation.Click += new System.EventHandler(this.btnReservationsMakeReservation_Click);
            // 
            // lbReservationParticipants
            // 
            this.lbReservationParticipants.FormattingEnabled = true;
            this.lbReservationParticipants.Location = new System.Drawing.Point(232, 164);
            this.lbReservationParticipants.Name = "lbReservationParticipants";
            this.lbReservationParticipants.Size = new System.Drawing.Size(462, 212);
            this.lbReservationParticipants.TabIndex = 4;
            // 
            // btnReservationSearchParticipant
            // 
            this.btnReservationSearchParticipant.Location = new System.Drawing.Point(232, 121);
            this.btnReservationSearchParticipant.Name = "btnReservationSearchParticipant";
            this.btnReservationSearchParticipant.Size = new System.Drawing.Size(84, 37);
            this.btnReservationSearchParticipant.TabIndex = 5;
            this.btnReservationSearchParticipant.Text = "Search Participant";
            this.btnReservationSearchParticipant.UseVisualStyleBackColor = true;
            this.btnReservationSearchParticipant.Click += new System.EventHandler(this.btnReservationSearchParticipant_Click);
            // 
            // btnReservationAddParticipant
            // 
            this.btnReservationAddParticipant.Location = new System.Drawing.Point(322, 121);
            this.btnReservationAddParticipant.Name = "btnReservationAddParticipant";
            this.btnReservationAddParticipant.Size = new System.Drawing.Size(84, 37);
            this.btnReservationAddParticipant.TabIndex = 6;
            this.btnReservationAddParticipant.Text = "Add Participant";
            this.btnReservationAddParticipant.UseVisualStyleBackColor = true;
            this.btnReservationAddParticipant.Click += new System.EventHandler(this.btnReservationAddParticipant_Click);
            // 
            // lblReservationBeginDate
            // 
            this.lblReservationBeginDate.AutoSize = true;
            this.lblReservationBeginDate.Location = new System.Drawing.Point(425, 83);
            this.lblReservationBeginDate.Name = "lblReservationBeginDate";
            this.lblReservationBeginDate.Size = new System.Drawing.Size(63, 13);
            this.lblReservationBeginDate.TabIndex = 7;
            this.lblReservationBeginDate.Text = "Begin Date:";
            // 
            // lblReservationEndDate
            // 
            this.lblReservationEndDate.AutoSize = true;
            this.lblReservationEndDate.Location = new System.Drawing.Point(425, 121);
            this.lblReservationEndDate.Name = "lblReservationEndDate";
            this.lblReservationEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblReservationEndDate.TabIndex = 8;
            this.lblReservationEndDate.Text = "End Date:";
            // 
            // dtpReservationBeginDate
            // 
            this.dtpReservationBeginDate.Location = new System.Drawing.Point(494, 77);
            this.dtpReservationBeginDate.Name = "dtpReservationBeginDate";
            this.dtpReservationBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReservationBeginDate.TabIndex = 9;
            // 
            // dtpReservationEndDate
            // 
            this.dtpReservationEndDate.Location = new System.Drawing.Point(494, 115);
            this.dtpReservationEndDate.Name = "dtpReservationEndDate";
            this.dtpReservationEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReservationEndDate.TabIndex = 10;
            // 
            // tbReservationSearchParticipant
            // 
            this.tbReservationSearchParticipant.Location = new System.Drawing.Point(232, 95);
            this.tbReservationSearchParticipant.Name = "tbReservationSearchParticipant";
            this.tbReservationSearchParticipant.Size = new System.Drawing.Size(174, 20);
            this.tbReservationSearchParticipant.TabIndex = 11;
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(619, 12);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(75, 35);
            this.btnParticipants.TabIndex = 12;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // MakeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.tbReservationSearchParticipant);
            this.Controls.Add(this.dtpReservationEndDate);
            this.Controls.Add(this.dtpReservationBeginDate);
            this.Controls.Add(this.lblReservationEndDate);
            this.Controls.Add(this.lblReservationBeginDate);
            this.Controls.Add(this.btnReservationAddParticipant);
            this.Controls.Add(this.btnReservationSearchParticipant);
            this.Controls.Add(this.lbReservationParticipants);
            this.Controls.Add(this.btnReservationsMakeReservation);
            this.Controls.Add(this.btnReservationsReservations);
            this.Controls.Add(this.btnReservationsLocation);
            this.Controls.Add(this.lbReservationEvents);
            this.Name = "MakeReservationForm";
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReservationEvents;
        private System.Windows.Forms.Button btnReservationsLocation;
        private System.Windows.Forms.Button btnReservationsReservations;
        private System.Windows.Forms.Button btnReservationsMakeReservation;
        private System.Windows.Forms.ListBox lbReservationParticipants;
        private System.Windows.Forms.Button btnReservationSearchParticipant;
        private System.Windows.Forms.Button btnReservationAddParticipant;
        private System.Windows.Forms.Label lblReservationBeginDate;
        private System.Windows.Forms.Label lblReservationEndDate;
        private System.Windows.Forms.DateTimePicker dtpReservationBeginDate;
        private System.Windows.Forms.DateTimePicker dtpReservationEndDate;
        private System.Windows.Forms.TextBox tbReservationSearchParticipant;
        private System.Windows.Forms.Button btnParticipants;
    }
}