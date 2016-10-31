namespace EyeCT4Events.GUI
{
    partial class RfidForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ledChk = new System.Windows.Forms.CheckBox();
            this.antennaChk = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "NULL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ledChk
            // 
            this.ledChk.AutoSize = true;
            this.ledChk.Checked = true;
            this.ledChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ledChk.Location = new System.Drawing.Point(130, 39);
            this.ledChk.Name = "ledChk";
            this.ledChk.Size = new System.Drawing.Size(86, 17);
            this.ledChk.TabIndex = 14;
            this.ledChk.Text = "Led Enabled";
            this.ledChk.UseVisualStyleBackColor = true;
            this.ledChk.CheckedChanged += new System.EventHandler(this.ledChk_CheckedChanged);
            // 
            // antennaChk
            // 
            this.antennaChk.AutoSize = true;
            this.antennaChk.Checked = true;
            this.antennaChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.antennaChk.Location = new System.Drawing.Point(16, 39);
            this.antennaChk.Name = "antennaChk";
            this.antennaChk.Size = new System.Drawing.Size(108, 17);
            this.antennaChk.TabIndex = 13;
            this.antennaChk.Text = "Antenna Enabled";
            this.antennaChk.UseVisualStyleBackColor = true;
            this.antennaChk.CheckedChanged += new System.EventHandler(this.antennaChk_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RfidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 67);
            this.Controls.Add(this.ledChk);
            this.Controls.Add(this.antennaChk);
            this.Controls.Add(this.label1);
            this.Name = "RfidForm";
            this.Text = "RFIDclass";
            this.Load += new System.EventHandler(this.RFIDclass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ledChk;
        private System.Windows.Forms.CheckBox antennaChk;
        private System.Windows.Forms.Timer timer1;
    }
}