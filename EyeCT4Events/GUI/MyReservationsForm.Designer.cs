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
            this.lbMyReservationsEvents.ItemHeight = 25;
            this.lbMyReservationsEvents.Location = new System.Drawing.Point(24, 165);
            this.lbMyReservationsEvents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbMyReservationsEvents.Name = "lbMyReservationsEvents";
            this.lbMyReservationsEvents.Size = new System.Drawing.Size(340, 604);
            this.lbMyReservationsEvents.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(994, 42);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbMyReservationsReservations
            // 
            this.lbMyReservationsReservations.FormattingEnabled = true;
            this.lbMyReservationsReservations.ItemHeight = 25;
            this.lbMyReservationsReservations.Location = new System.Drawing.Point(510, 165);
            this.lbMyReservationsReservations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbMyReservationsReservations.Name = "lbMyReservationsReservations";
            this.lbMyReservationsReservations.Size = new System.Drawing.Size(380, 604);
            this.lbMyReservationsReservations.TabIndex = 2;
            // 
            // lbMyReservationsParticipants
            // 
            this.lbMyReservationsParticipants.FormattingEnabled = true;
            this.lbMyReservationsParticipants.ItemHeight = 25;
            this.lbMyReservationsParticipants.Location = new System.Drawing.Point(994, 165);
            this.lbMyReservationsParticipants.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbMyReservationsParticipants.Name = "lbMyReservationsParticipants";
            this.lbMyReservationsParticipants.Size = new System.Drawing.Size(362, 604);
            this.lbMyReservationsParticipants.TabIndex = 3;
            // 
            // lblMyReservationsDate
            // 
            this.lblMyReservationsDate.AutoSize = true;
            this.lblMyReservationsDate.Location = new System.Drawing.Point(863, 47);
            this.lblMyReservationsDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMyReservationsDate.Name = "lblMyReservationsDate";
            this.lblMyReservationsDate.Size = new System.Drawing.Size(80, 25);
            this.lblMyReservationsDate.TabIndex = 4;
            this.lblMyReservationsDate.Text = "Datum:";
            // 
            // MyReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 788);
            this.Controls.Add(this.lblMyReservationsDate);
            this.Controls.Add(this.lbMyReservationsParticipants);
            this.Controls.Add(this.lbMyReservationsReservations);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbMyReservationsEvents);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MyReservationsForm";
            this.Text = "Mijn Reserveringen";
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