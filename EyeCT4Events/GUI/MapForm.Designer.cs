namespace EyeCT4Events
{
    partial class MapForm
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
            this.btnMapChooseLocation = new System.Windows.Forms.Button();
            this.pbMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMapChooseLocation
            // 
            this.btnMapChooseLocation.Location = new System.Drawing.Point(1472, 23);
            this.btnMapChooseLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMapChooseLocation.Name = "btnMapChooseLocation";
            this.btnMapChooseLocation.Size = new System.Drawing.Size(236, 79);
            this.btnMapChooseLocation.TabIndex = 0;
            this.btnMapChooseLocation.Text = "Kies Locatie";
            this.btnMapChooseLocation.UseVisualStyleBackColor = true;
            this.btnMapChooseLocation.Click += new System.EventHandler(this.btnMapChooseLocation_Click);
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(24, 173);
            this.pbMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(1684, 733);
            this.pbMap.TabIndex = 1;
            this.pbMap.TabStop = false;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 929);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.btnMapChooseLocation);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MapForm";
            this.Text = "Kaart";
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMapChooseLocation;
        private System.Windows.Forms.PictureBox pbMap;
    }
}