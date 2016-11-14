namespace EyeCT4Events
{
    partial class HiredMaterialForm
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
            this.btnLease = new System.Windows.Forms.Button();
            this.lbMaterial = new System.Windows.Forms.ListBox();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLease
            // 
            this.btnLease.Location = new System.Drawing.Point(12, 68);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(75, 36);
            this.btnLease.TabIndex = 0;
            this.btnLease.Text = "Verhuur";
            this.btnLease.UseVisualStyleBackColor = true;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // lbMaterial
            // 
            this.lbMaterial.FormattingEnabled = true;
            this.lbMaterial.Location = new System.Drawing.Point(149, 3);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(721, 459);
            this.lbMaterial.TabIndex = 2;
            this.lbMaterial.SelectedIndexChanged += new System.EventHandler(this.lbMaterial_SelectedIndexChanged);
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(12, 12);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(75, 36);
            this.btnParticipants.TabIndex = 4;
            this.btnParticipants.Text = "Deelnemers";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // HiredMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 481);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.btnLease);
            this.Name = "HiredMaterialForm";
            this.Text = "Hired Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HiredMaterialForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLease;
        private System.Windows.Forms.ListBox lbMaterial;
        private System.Windows.Forms.Button btnParticipants;
    }
}