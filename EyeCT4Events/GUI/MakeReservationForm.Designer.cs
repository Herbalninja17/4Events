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
            this.lbReservationEvents.ItemHeight = 25;
            this.lbReservationEvents.Location = new System.Drawing.Point(24, 13);
            this.lbReservationEvents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbReservationEvents.Name = "lbReservationEvents";
            this.lbReservationEvents.Size = new System.Drawing.Size(360, 704);
            this.lbReservationEvents.TabIndex = 0;
            // 
            // btnReservationsLocation
            // 
            this.btnReservationsLocation.Location = new System.Drawing.Point(464, 23);
            this.btnReservationsLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReservationsLocation.Name = "btnReservationsLocation";
            this.btnReservationsLocation.Size = new System.Drawing.Size(150, 67);
            this.btnReservationsLocation.TabIndex = 1;
            this.btnReservationsLocation.Text = "Kies Locatie";
            this.btnReservationsLocation.UseVisualStyleBackColor = true;
            this.btnReservationsLocation.Click += new System.EventHandler(this.btnReservationsLocation_Click);
            // 
            // btnReservationsReservations
            // 
            this.btnReservationsReservations.Location = new System.Drawing.Point(732, 23);
            this.btnReservationsReservations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReservationsReservations.Name = "btnReservationsReservations";
            this.btnReservationsReservations.Size = new System.Drawing.Size(160, 67);
            this.btnReservationsReservations.TabIndex = 2;
            this.btnReservationsReservations.Text = "Reserveringen";
            this.btnReservationsReservations.UseVisualStyleBackColor = true;
            this.btnReservationsReservations.Click += new System.EventHandler(this.btnReservationsReservations_Click);
            // 
            // btnReservationsMakeReservation
            // 
            this.btnReservationsMakeReservation.Location = new System.Drawing.Point(1008, 23);
            this.btnReservationsMakeReservation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReservationsMakeReservation.Name = "btnReservationsMakeReservation";
            this.btnReservationsMakeReservation.Size = new System.Drawing.Size(150, 67);
            this.btnReservationsMakeReservation.TabIndex = 3;
            this.btnReservationsMakeReservation.Text = "Bevestig Reservering";
            this.btnReservationsMakeReservation.UseVisualStyleBackColor = true;
            this.btnReservationsMakeReservation.Click += new System.EventHandler(this.btnReservationsMakeReservation_Click);
            // 
            // lbReservationParticipants
            // 
            this.lbReservationParticipants.FormattingEnabled = true;
            this.lbReservationParticipants.ItemHeight = 25;
            this.lbReservationParticipants.Location = new System.Drawing.Point(464, 315);
            this.lbReservationParticipants.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbReservationParticipants.Name = "lbReservationParticipants";
            this.lbReservationParticipants.Size = new System.Drawing.Size(920, 404);
            this.lbReservationParticipants.TabIndex = 4;
            // 
            // btnReservationSearchParticipant
            // 
            this.btnReservationSearchParticipant.Location = new System.Drawing.Point(464, 233);
            this.btnReservationSearchParticipant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReservationSearchParticipant.Name = "btnReservationSearchParticipant";
            this.btnReservationSearchParticipant.Size = new System.Drawing.Size(168, 71);
            this.btnReservationSearchParticipant.TabIndex = 5;
            this.btnReservationSearchParticipant.Text = "Zoek Deelnemer";
            this.btnReservationSearchParticipant.UseVisualStyleBackColor = true;
            this.btnReservationSearchParticipant.Click += new System.EventHandler(this.btnReservationSearchParticipant_Click);
            // 
            // btnReservationAddParticipant
            // 
            this.btnReservationAddParticipant.Location = new System.Drawing.Point(644, 233);
            this.btnReservationAddParticipant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReservationAddParticipant.Name = "btnReservationAddParticipant";
            this.btnReservationAddParticipant.Size = new System.Drawing.Size(168, 71);
            this.btnReservationAddParticipant.TabIndex = 6;
            this.btnReservationAddParticipant.Text = "Voeg deelnemer toe";
            this.btnReservationAddParticipant.UseVisualStyleBackColor = true;
            this.btnReservationAddParticipant.Click += new System.EventHandler(this.btnReservationAddParticipant_Click);
            // 
            // lblReservationBeginDate
            // 
            this.lblReservationBeginDate.AutoSize = true;
            this.lblReservationBeginDate.Location = new System.Drawing.Point(835, 153);
            this.lblReservationBeginDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReservationBeginDate.Name = "lblReservationBeginDate";
            this.lblReservationBeginDate.Size = new System.Drawing.Size(141, 25);
            this.lblReservationBeginDate.TabIndex = 7;
            this.lblReservationBeginDate.Text = "Begin Datum:";
            // 
            // lblReservationEndDate
            // 
            this.lblReservationEndDate.AutoSize = true;
            this.lblReservationEndDate.Location = new System.Drawing.Point(833, 226);
            this.lblReservationEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReservationEndDate.Name = "lblReservationEndDate";
            this.lblReservationEndDate.Size = new System.Drawing.Size(129, 25);
            this.lblReservationEndDate.TabIndex = 8;
            this.lblReservationEndDate.Text = "Eind Datum:";
            // 
            // dtpReservationBeginDate
            // 
            this.dtpReservationBeginDate.Location = new System.Drawing.Point(988, 148);
            this.dtpReservationBeginDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpReservationBeginDate.Name = "dtpReservationBeginDate";
            this.dtpReservationBeginDate.Size = new System.Drawing.Size(396, 31);
            this.dtpReservationBeginDate.TabIndex = 9;
            // 
            // dtpReservationEndDate
            // 
            this.dtpReservationEndDate.Location = new System.Drawing.Point(988, 221);
            this.dtpReservationEndDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpReservationEndDate.Name = "dtpReservationEndDate";
            this.dtpReservationEndDate.Size = new System.Drawing.Size(396, 31);
            this.dtpReservationEndDate.TabIndex = 10;
            // 
            // tbReservationSearchParticipant
            // 
            this.tbReservationSearchParticipant.Location = new System.Drawing.Point(464, 183);
            this.tbReservationSearchParticipant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbReservationSearchParticipant.Name = "tbReservationSearchParticipant";
            this.tbReservationSearchParticipant.Size = new System.Drawing.Size(344, 31);
            this.tbReservationSearchParticipant.TabIndex = 11;
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(1238, 23);
            this.btnParticipants.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(150, 67);
            this.btnParticipants.TabIndex = 12;
            this.btnParticipants.Text = "Deelnemers";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // MakeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 750);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MakeReservationForm";
            this.Text = "Reservering";
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