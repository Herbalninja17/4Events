namespace EyeCT4Events
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
            this.btnEditParticipant = new System.Windows.Forms.Button();
            this.btnCreateParticipant = new System.Windows.Forms.Button();
            this.lbParticipantsPresent = new System.Windows.Forms.ListBox();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.lbParticipantsNotPresent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParticipantsPaid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(12, 199);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(88, 43);
            this.btnEvents.TabIndex = 28;
            this.btnEvents.Text = "Evenementen";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnEditParticipant
            // 
            this.btnEditParticipant.Location = new System.Drawing.Point(12, 141);
            this.btnEditParticipant.Name = "btnEditParticipant";
            this.btnEditParticipant.Size = new System.Drawing.Size(88, 43);
            this.btnEditParticipant.TabIndex = 26;
            this.btnEditParticipant.Text = "Wijzig deelnemer";
            this.btnEditParticipant.UseVisualStyleBackColor = true;
            this.btnEditParticipant.Click += new System.EventHandler(this.btnEditParticipant_Click);
            // 
            // btnCreateParticipant
            // 
            this.btnCreateParticipant.Location = new System.Drawing.Point(12, 86);
            this.btnCreateParticipant.Name = "btnCreateParticipant";
            this.btnCreateParticipant.Size = new System.Drawing.Size(88, 43);
            this.btnCreateParticipant.TabIndex = 25;
            this.btnCreateParticipant.Text = "Voeg deelnemer toe";
            this.btnCreateParticipant.UseVisualStyleBackColor = true;
            this.btnCreateParticipant.Click += new System.EventHandler(this.btnCreateParticipant_Click);
            // 
            // lbParticipantsPresent
            // 
            this.lbParticipantsPresent.FormattingEnabled = true;
            this.lbParticipantsPresent.Location = new System.Drawing.Point(152, 51);
            this.lbParticipantsPresent.Name = "lbParticipantsPresent";
            this.lbParticipantsPresent.Size = new System.Drawing.Size(342, 316);
            this.lbParticipantsPresent.TabIndex = 29;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(12, 28);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(88, 43);
            this.btnMaterial.TabIndex = 30;
            this.btnMaterial.Text = "Materiaal";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // lbParticipantsNotPresent
            // 
            this.lbParticipantsNotPresent.FormattingEnabled = true;
            this.lbParticipantsNotPresent.Location = new System.Drawing.Point(541, 54);
            this.lbParticipantsNotPresent.Name = "lbParticipantsNotPresent";
            this.lbParticipantsNotPresent.Size = new System.Drawing.Size(342, 316);
            this.lbParticipantsNotPresent.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Aanwezig:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Afwezig:";
            // 
            // btnParticipantsPaid
            // 
            this.btnParticipantsPaid.Location = new System.Drawing.Point(385, 12);
            this.btnParticipantsPaid.Name = "btnParticipantsPaid";
            this.btnParticipantsPaid.Size = new System.Drawing.Size(109, 35);
            this.btnParticipantsPaid.TabIndex = 34;
            this.btnParticipantsPaid.Text = "Aanwezig met betaaldstatus";
            this.btnParticipantsPaid.UseVisualStyleBackColor = true;
            this.btnParticipantsPaid.Click += new System.EventHandler(this.btnParticipantsPaid_Click);
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 382);
            this.Controls.Add(this.btnParticipantsPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbParticipantsNotPresent);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.lbParticipantsPresent);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnEditParticipant);
            this.Controls.Add(this.btnCreateParticipant);
            this.Name = "ParticipantsForm";
            this.Text = "Deelnemers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnEditParticipant;
        private System.Windows.Forms.Button btnCreateParticipant;
        private System.Windows.Forms.ListBox lbParticipantsPresent;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.ListBox lbParticipantsNotPresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParticipantsPaid;
    }
}