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
            this.lbMyReservationsParticipants = new System.Windows.Forms.ListBox();
            this.lblMyReservationsDate = new System.Windows.Forms.Label();
            this.btnPayReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMyReservationsEvents
            // 
            this.lbMyReservationsEvents.FormattingEnabled = true;
            this.lbMyReservationsEvents.Location = new System.Drawing.Point(16, 33);
            this.lbMyReservationsEvents.Name = "lbMyReservationsEvents";
            this.lbMyReservationsEvents.Size = new System.Drawing.Size(258, 316);
            this.lbMyReservationsEvents.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbMyReservationsParticipants
            // 
            this.lbMyReservationsParticipants.FormattingEnabled = true;
            this.lbMyReservationsParticipants.Location = new System.Drawing.Point(280, 33);
            this.lbMyReservationsParticipants.Name = "lbMyReservationsParticipants";
            this.lbMyReservationsParticipants.Size = new System.Drawing.Size(258, 316);
            this.lbMyReservationsParticipants.TabIndex = 3;
            // 
            // lblMyReservationsDate
            // 
            this.lblMyReservationsDate.AutoSize = true;
            this.lblMyReservationsDate.Location = new System.Drawing.Point(273, 9);
            this.lblMyReservationsDate.Name = "lblMyReservationsDate";
            this.lblMyReservationsDate.Size = new System.Drawing.Size(41, 13);
            this.lblMyReservationsDate.TabIndex = 4;
            this.lblMyReservationsDate.Text = "Datum:";
            // 
            // btnPayReservation
            // 
            this.btnPayReservation.Location = new System.Drawing.Point(433, 367);
            this.btnPayReservation.Name = "btnPayReservation";
            this.btnPayReservation.Size = new System.Drawing.Size(112, 31);
            this.btnPayReservation.TabIndex = 5;
            this.btnPayReservation.Text = "Betaal Reservering";
            this.btnPayReservation.UseVisualStyleBackColor = true;
            this.btnPayReservation.Click += new System.EventHandler(this.btnPayReservation_Click);
            // 
            // MyReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 410);
            this.Controls.Add(this.btnPayReservation);
            this.Controls.Add(this.lblMyReservationsDate);
            this.Controls.Add(this.lbMyReservationsParticipants);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbMyReservationsEvents);
            this.Name = "MyReservationsForm";
            this.Text = "Mijn Reserveringen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyReservationsForm_FormClosed);
            this.Load += new System.EventHandler(this.MyReservationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMyReservationsEvents;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbMyReservationsParticipants;
        private System.Windows.Forms.Label lblMyReservationsDate;
        private System.Windows.Forms.Button btnPayReservation;
    }
}