﻿namespace EyeCT4Events
{
    partial class ParticipantsForm
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
            this.btnCreateParticipant = new System.Windows.Forms.Button();
            this.lbParticipantsParticipants = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(12, 269);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(75, 43);
            this.btnParticipants.TabIndex = 28;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.Location = new System.Drawing.Point(12, 207);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteParticipant.TabIndex = 27;
            this.btnDeleteParticipant.Text = "Delete Participant";
            this.btnDeleteParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // btnEditParticipant
            // 
            this.btnEditParticipant.Location = new System.Drawing.Point(12, 141);
            this.btnEditParticipant.Name = "btnEditParticipant";
            this.btnEditParticipant.Size = new System.Drawing.Size(75, 43);
            this.btnEditParticipant.TabIndex = 26;
            this.btnEditParticipant.Text = "Edit Participant";
            this.btnEditParticipant.UseVisualStyleBackColor = true;
            this.btnEditParticipant.Click += new System.EventHandler(this.btnEditParticipant_Click);
            // 
            // btnCreateParticipant
            // 
            this.btnCreateParticipant.Location = new System.Drawing.Point(12, 86);
            this.btnCreateParticipant.Name = "btnCreateParticipant";
            this.btnCreateParticipant.Size = new System.Drawing.Size(75, 43);
            this.btnCreateParticipant.TabIndex = 25;
            this.btnCreateParticipant.Text = "Create Participant";
            this.btnCreateParticipant.UseVisualStyleBackColor = true;
            this.btnCreateParticipant.Click += new System.EventHandler(this.btnCreateParticipant_Click);
            // 
            // lbParticipantsParticipants
            // 
            this.lbParticipantsParticipants.FormattingEnabled = true;
            this.lbParticipantsParticipants.Location = new System.Drawing.Point(152, 12);
            this.lbParticipantsParticipants.Name = "lbParticipantsParticipants";
            this.lbParticipantsParticipants.Size = new System.Drawing.Size(342, 355);
            this.lbParticipantsParticipants.TabIndex = 29;
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 382);
            this.Controls.Add(this.lbParticipantsParticipants);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnDeleteParticipant);
            this.Controls.Add(this.btnEditParticipant);
            this.Controls.Add(this.btnCreateParticipant);
            this.Name = "ParticipantsForm";
            this.Text = "Participants";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.Button btnEditParticipant;
        private System.Windows.Forms.Button btnCreateParticipant;
        private System.Windows.Forms.ListBox lbParticipantsParticipants;
    }
}