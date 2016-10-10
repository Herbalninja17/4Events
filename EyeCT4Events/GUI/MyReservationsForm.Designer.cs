namespace EyeCT4Events
{
    partial class MyReservationsForm
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
            this.lbMyReservationsEvents = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbMyReservationsReservations = new System.Windows.Forms.ListBox();
            this.lbMyReservationsParticipants = new System.Windows.Forms.ListBox();
            this.lblMyReservationsDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMyReservationsEvents
            // 
            this.lbMyReservationsEvents.FormattingEnabled = true;
            this.lbMyReservationsEvents.Location = new System.Drawing.Point(12, 86);
            this.lbMyReservationsEvents.Name = "lbMyReservationsEvents";
            this.lbMyReservationsEvents.Size = new System.Drawing.Size(172, 316);
            this.lbMyReservationsEvents.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbMyReservationsReservations
            // 
            this.lbMyReservationsReservations.FormattingEnabled = true;
            this.lbMyReservationsReservations.Location = new System.Drawing.Point(255, 86);
            this.lbMyReservationsReservations.Name = "lbMyReservationsReservations";
            this.lbMyReservationsReservations.Size = new System.Drawing.Size(192, 316);
            this.lbMyReservationsReservations.TabIndex = 2;
            // 
            // lbMyReservationsParticipants
            // 
            this.lbMyReservationsParticipants.FormattingEnabled = true;
            this.lbMyReservationsParticipants.Location = new System.Drawing.Point(497, 86);
            this.lbMyReservationsParticipants.Name = "lbMyReservationsParticipants";
            this.lbMyReservationsParticipants.Size = new System.Drawing.Size(183, 316);
            this.lbMyReservationsParticipants.TabIndex = 3;
            // 
            // lblMyReservationsDate
            // 
            this.lblMyReservationsDate.AutoSize = true;
            this.lblMyReservationsDate.Location = new System.Drawing.Point(425, 29);
            this.lblMyReservationsDate.Name = "lblMyReservationsDate";
            this.lblMyReservationsDate.Size = new System.Drawing.Size(33, 13);
            this.lblMyReservationsDate.TabIndex = 4;
            this.lblMyReservationsDate.Text = "Date:";
            // 
            // MyReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 410);
            this.Controls.Add(this.lblMyReservationsDate);
            this.Controls.Add(this.lbMyReservationsParticipants);
            this.Controls.Add(this.lbMyReservationsReservations);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbMyReservationsEvents);
            this.Name = "MyReservationsForm";
            this.Text = "My Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMyReservationsEvents;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbMyReservationsReservations;
        private System.Windows.Forms.ListBox lbMyReservationsParticipants;
        private System.Windows.Forms.Label lblMyReservationsDate;
    }
}