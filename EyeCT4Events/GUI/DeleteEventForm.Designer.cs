﻿namespace EyeCT4Events
{
    partial class DeleteEventForm
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
            this.lbDeleteEvent = new System.Windows.Forms.ListBox();
            this.tbDeleteEventName = new System.Windows.Forms.TextBox();
            this.lblDeleteEventName = new System.Windows.Forms.Label();
            this.btnDeleteEventSearch = new System.Windows.Forms.Button();
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
            this.btnEditEvent.Location = new System.Drawing.Point(12, 214);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(75, 43);
            this.btnEditEvent.TabIndex = 22;
            this.btnEditEvent.Text = "Evenement Aanpassen";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(12, 159);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(75, 43);
            this.btnCreateEvent.TabIndex = 21;
            this.btnCreateEvent.Text = "Evenement Aanmaken";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lbDeleteEvent
            // 
            this.lbDeleteEvent.FormattingEnabled = true;
            this.lbDeleteEvent.Location = new System.Drawing.Point(170, 86);
            this.lbDeleteEvent.Name = "lbDeleteEvent";
            this.lbDeleteEvent.Size = new System.Drawing.Size(323, 225);
            this.lbDeleteEvent.TabIndex = 25;
            // 
            // tbDeleteEventName
            // 
            this.tbDeleteEventName.Location = new System.Drawing.Point(268, 12);
            this.tbDeleteEventName.Name = "tbDeleteEventName";
            this.tbDeleteEventName.Size = new System.Drawing.Size(225, 20);
            this.tbDeleteEventName.TabIndex = 26;
            // 
            // lblDeleteEventName
            // 
            this.lblDeleteEventName.AutoSize = true;
            this.lblDeleteEventName.Location = new System.Drawing.Point(167, 15);
            this.lblDeleteEventName.Name = "lblDeleteEventName";
            this.lblDeleteEventName.Size = new System.Drawing.Size(95, 13);
            this.lblDeleteEventName.TabIndex = 27;
            this.lblDeleteEventName.Text = "Evenement Naam:";
            // 
            // btnDeleteEventSearch
            // 
            this.btnDeleteEventSearch.Location = new System.Drawing.Point(418, 38);
            this.btnDeleteEventSearch.Name = "btnDeleteEventSearch";
            this.btnDeleteEventSearch.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteEventSearch.TabIndex = 28;
            this.btnDeleteEventSearch.Text = "Zoeken";
            this.btnDeleteEventSearch.UseVisualStyleBackColor = true;
            this.btnDeleteEventSearch.Click += new System.EventHandler(this.btnDeleteEventSearch_Click);
            // 
            // DeleteEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 369);
            this.Controls.Add(this.btnDeleteEventSearch);
            this.Controls.Add(this.lblDeleteEventName);
            this.Controls.Add(this.tbDeleteEventName);
            this.Controls.Add(this.lbDeleteEvent);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Name = "DeleteEventForm";
            this.Text = "Delete Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.ListBox lbDeleteEvent;
        private System.Windows.Forms.TextBox tbDeleteEventName;
        private System.Windows.Forms.Label lblDeleteEventName;
        private System.Windows.Forms.Button btnDeleteEventSearch;
    }
}