namespace EyeCT4Events
{
    partial class EventBeheerForm
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
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.lbEventBeheer = new System.Windows.Forms.ListBox();
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
            // btnEditEvent
            // 
            this.btnEditEvent.Location = new System.Drawing.Point(12, 211);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(75, 43);
            this.btnEditEvent.TabIndex = 22;
            this.btnEditEvent.Text = "Evenement Aanpassen";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(12, 156);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(75, 43);
            this.btnCreateEvent.TabIndex = 21;
            this.btnCreateEvent.Text = "Evenement Aanmaken";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lbEventBeheer
            // 
            this.lbEventBeheer.FormattingEnabled = true;
            this.lbEventBeheer.Location = new System.Drawing.Point(149, 12);
            this.lbEventBeheer.Name = "lbEventBeheer";
            this.lbEventBeheer.Size = new System.Drawing.Size(314, 342);
            this.lbEventBeheer.TabIndex = 25;
            // 
            // EventBeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 366);
            this.Controls.Add(this.lbEventBeheer);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Name = "EventBeheerForm";
            this.Text = "Event Beheer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.ListBox lbEventBeheer;
    }
}