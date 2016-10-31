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
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            this.btnEditParticipant = new System.Windows.Forms.Button();
            this.btnCreateParticipant = new System.Windows.Forms.Button();
            this.lbParticipantsParticipants = new System.Windows.Forms.ListBox();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(24, 517);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(177, 83);
            this.btnEvents.TabIndex = 28;
            this.btnEvents.Text = "Evenementen";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.Location = new System.Drawing.Point(24, 398);
            this.btnDeleteParticipant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(177, 83);
            this.btnDeleteParticipant.TabIndex = 27;
            this.btnDeleteParticipant.Text = "Verwijder deelnemer";
            this.btnDeleteParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // btnEditParticipant
            // 
            this.btnEditParticipant.Location = new System.Drawing.Point(24, 271);
            this.btnEditParticipant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditParticipant.Name = "btnEditParticipant";
            this.btnEditParticipant.Size = new System.Drawing.Size(177, 83);
            this.btnEditParticipant.TabIndex = 26;
            this.btnEditParticipant.Text = "Wijzig deelnemer";
            this.btnEditParticipant.UseVisualStyleBackColor = true;
            this.btnEditParticipant.Click += new System.EventHandler(this.btnEditParticipant_Click);
            // 
            // btnCreateParticipant
            // 
            this.btnCreateParticipant.Location = new System.Drawing.Point(24, 165);
            this.btnCreateParticipant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateParticipant.Name = "btnCreateParticipant";
            this.btnCreateParticipant.Size = new System.Drawing.Size(177, 83);
            this.btnCreateParticipant.TabIndex = 25;
            this.btnCreateParticipant.Text = "Voeg deelnemer toe";
            this.btnCreateParticipant.UseVisualStyleBackColor = true;
            this.btnCreateParticipant.Click += new System.EventHandler(this.btnCreateParticipant_Click);
            // 
            // lbParticipantsParticipants
            // 
            this.lbParticipantsParticipants.FormattingEnabled = true;
            this.lbParticipantsParticipants.ItemHeight = 25;
            this.lbParticipantsParticipants.Location = new System.Drawing.Point(304, 23);
            this.lbParticipantsParticipants.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbParticipantsParticipants.Name = "lbParticipantsParticipants";
            this.lbParticipantsParticipants.Size = new System.Drawing.Size(680, 679);
            this.lbParticipantsParticipants.TabIndex = 29;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(24, 54);
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(177, 83);
            this.btnMaterial.TabIndex = 30;
            this.btnMaterial.Text = "Materiaal";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 735);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.lbParticipantsParticipants);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnDeleteParticipant);
            this.Controls.Add(this.btnEditParticipant);
            this.Controls.Add(this.btnCreateParticipant);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ParticipantsForm";
            this.Text = "Deelnemers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.Button btnEditParticipant;
        private System.Windows.Forms.Button btnCreateParticipant;
        private System.Windows.Forms.ListBox lbParticipantsParticipants;
        private System.Windows.Forms.Button btnMaterial;
    }
}