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
            this.btnHired = new System.Windows.Forms.Button();
            this.lbMaterial = new System.Windows.Forms.ListBox();
            this.lbDate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLease
            // 
            this.btnLease.Location = new System.Drawing.Point(12, 12);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(75, 36);
            this.btnLease.TabIndex = 0;
            this.btnLease.Text = "Lease";
            this.btnLease.UseVisualStyleBackColor = true;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // btnHired
            // 
            this.btnHired.Location = new System.Drawing.Point(12, 70);
            this.btnHired.Name = "btnHired";
            this.btnHired.Size = new System.Drawing.Size(75, 36);
            this.btnHired.TabIndex = 1;
            this.btnHired.Text = "Hired";
            this.btnHired.UseVisualStyleBackColor = true;
            this.btnHired.Click += new System.EventHandler(this.btnHired_Click);
            // 
            // lbMaterial
            // 
            this.lbMaterial.FormattingEnabled = true;
            this.lbMaterial.Location = new System.Drawing.Point(149, 3);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(255, 459);
            this.lbMaterial.TabIndex = 2;
            // 
            // lbDate
            // 
            this.lbDate.FormattingEnabled = true;
            this.lbDate.Location = new System.Drawing.Point(441, 3);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(255, 459);
            this.lbDate.TabIndex = 3;
            // 
            // HiredMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 481);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.btnHired);
            this.Controls.Add(this.btnLease);
            this.Name = "HiredMaterialForm";
            this.Text = "Hired Material";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLease;
        private System.Windows.Forms.Button btnHired;
        private System.Windows.Forms.ListBox lbMaterial;
        private System.Windows.Forms.ListBox lbDate;
    }
}