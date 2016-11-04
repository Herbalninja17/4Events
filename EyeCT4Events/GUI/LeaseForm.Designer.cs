namespace EyeCT4Events
{
    partial class LeaseForm
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
            this.btnHired = new System.Windows.Forms.Button();
            this.lbLeaseMaterial = new System.Windows.Forms.ListBox();
            this.lblLeaseSearchMaterial = new System.Windows.Forms.Label();
            this.tbLeaseSearchMaterial = new System.Windows.Forms.TextBox();
            this.nudLeaseQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpLeaseEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLeaseStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblLeaseStartDate = new System.Windows.Forms.Label();
            this.lblLeaseEndDate = new System.Windows.Forms.Label();
            this.lblLeaseQuantity = new System.Windows.Forms.Label();
            this.btnLeaseSearch = new System.Windows.Forms.Button();
            this.btnLeaseLease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeaseQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHired
            // 
            this.btnHired.Location = new System.Drawing.Point(24, 23);
            this.btnHired.Margin = new System.Windows.Forms.Padding(6);
            this.btnHired.Name = "btnHired";
            this.btnHired.Size = new System.Drawing.Size(150, 69);
            this.btnHired.TabIndex = 3;
            this.btnHired.Text = "Gehuurd";
            this.btnHired.UseVisualStyleBackColor = true;
            this.btnHired.Click += new System.EventHandler(this.btnHired_Click);
            // 
            // lbLeaseMaterial
            // 
            this.lbLeaseMaterial.FormattingEnabled = true;
            this.lbLeaseMaterial.ItemHeight = 25;
            this.lbLeaseMaterial.Location = new System.Drawing.Point(24, 238);
            this.lbLeaseMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.lbLeaseMaterial.Name = "lbLeaseMaterial";
            this.lbLeaseMaterial.Size = new System.Drawing.Size(1492, 404);
            this.lbLeaseMaterial.TabIndex = 4;
            // 
            // lblLeaseSearchMaterial
            // 
            this.lblLeaseSearchMaterial.AutoSize = true;
            this.lblLeaseSearchMaterial.Location = new System.Drawing.Point(982, 108);
            this.lblLeaseSearchMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLeaseSearchMaterial.Name = "lblLeaseSearchMaterial";
            this.lblLeaseSearchMaterial.Size = new System.Drawing.Size(161, 25);
            this.lblLeaseSearchMaterial.TabIndex = 5;
            this.lblLeaseSearchMaterial.Text = "Zoek Materiaal:";
            // 
            // tbLeaseSearchMaterial
            // 
            this.tbLeaseSearchMaterial.Location = new System.Drawing.Point(1162, 102);
            this.tbLeaseSearchMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.tbLeaseSearchMaterial.Name = "tbLeaseSearchMaterial";
            this.tbLeaseSearchMaterial.Size = new System.Drawing.Size(354, 31);
            this.tbLeaseSearchMaterial.TabIndex = 6;
            // 
            // nudLeaseQuantity
            // 
            this.nudLeaseQuantity.Location = new System.Drawing.Point(562, 154);
            this.nudLeaseQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.nudLeaseQuantity.Name = "nudLeaseQuantity";
            this.nudLeaseQuantity.Size = new System.Drawing.Size(240, 31);
            this.nudLeaseQuantity.TabIndex = 7;
            // 
            // dtpLeaseEndDate
            // 
            this.dtpLeaseEndDate.Location = new System.Drawing.Point(562, 90);
            this.dtpLeaseEndDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpLeaseEndDate.Name = "dtpLeaseEndDate";
            this.dtpLeaseEndDate.Size = new System.Drawing.Size(396, 31);
            this.dtpLeaseEndDate.TabIndex = 8;
            // 
            // dtpLeaseStartDate
            // 
            this.dtpLeaseStartDate.Location = new System.Drawing.Point(562, 23);
            this.dtpLeaseStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpLeaseStartDate.Name = "dtpLeaseStartDate";
            this.dtpLeaseStartDate.Size = new System.Drawing.Size(396, 31);
            this.dtpLeaseStartDate.TabIndex = 9;
            // 
            // lblLeaseStartDate
            // 
            this.lblLeaseStartDate.AutoSize = true;
            this.lblLeaseStartDate.Location = new System.Drawing.Point(368, 35);
            this.lblLeaseStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLeaseStartDate.Name = "lblLeaseStartDate";
            this.lblLeaseStartDate.Size = new System.Drawing.Size(131, 25);
            this.lblLeaseStartDate.TabIndex = 10;
            this.lblLeaseStartDate.Text = "Start Datum:";
            // 
            // lblLeaseEndDate
            // 
            this.lblLeaseEndDate.AutoSize = true;
            this.lblLeaseEndDate.Location = new System.Drawing.Point(368, 102);
            this.lblLeaseEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLeaseEndDate.Name = "lblLeaseEndDate";
            this.lblLeaseEndDate.Size = new System.Drawing.Size(129, 25);
            this.lblLeaseEndDate.TabIndex = 11;
            this.lblLeaseEndDate.Text = "Eind Datum:";
            // 
            // lblLeaseQuantity
            // 
            this.lblLeaseQuantity.AutoSize = true;
            this.lblLeaseQuantity.Location = new System.Drawing.Point(368, 158);
            this.lblLeaseQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLeaseQuantity.Name = "lblLeaseQuantity";
            this.lblLeaseQuantity.Size = new System.Drawing.Size(79, 25);
            this.lblLeaseQuantity.TabIndex = 12;
            this.lblLeaseQuantity.Text = "Aantal:";
            // 
            // btnLeaseSearch
            // 
            this.btnLeaseSearch.Location = new System.Drawing.Point(1370, 158);
            this.btnLeaseSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnLeaseSearch.Name = "btnLeaseSearch";
            this.btnLeaseSearch.Size = new System.Drawing.Size(150, 69);
            this.btnLeaseSearch.TabIndex = 13;
            this.btnLeaseSearch.Text = "Zoek";
            this.btnLeaseSearch.UseVisualStyleBackColor = true;
            this.btnLeaseSearch.Click += new System.EventHandler(this.btnLeaseSearch_Click);
            // 
            // btnLeaseLease
            // 
            this.btnLeaseLease.Location = new System.Drawing.Point(1162, 158);
            this.btnLeaseLease.Margin = new System.Windows.Forms.Padding(6);
            this.btnLeaseLease.Name = "btnLeaseLease";
            this.btnLeaseLease.Size = new System.Drawing.Size(150, 69);
            this.btnLeaseLease.TabIndex = 2;
            this.btnLeaseLease.Text = "Lease";
            this.btnLeaseLease.UseVisualStyleBackColor = true;
            this.btnLeaseLease.Click += new System.EventHandler(this.btnLeaseLease_Click);
            // 
            // LeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 675);
            this.Controls.Add(this.btnLeaseSearch);
            this.Controls.Add(this.lblLeaseQuantity);
            this.Controls.Add(this.lblLeaseEndDate);
            this.Controls.Add(this.lblLeaseStartDate);
            this.Controls.Add(this.dtpLeaseStartDate);
            this.Controls.Add(this.dtpLeaseEndDate);
            this.Controls.Add(this.nudLeaseQuantity);
            this.Controls.Add(this.tbLeaseSearchMaterial);
            this.Controls.Add(this.lblLeaseSearchMaterial);
            this.Controls.Add(this.lbLeaseMaterial);
            this.Controls.Add(this.btnHired);
            this.Controls.Add(this.btnLeaseLease);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LeaseForm";
            this.Text = "Lease";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeaseForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudLeaseQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHired;
        private System.Windows.Forms.ListBox lbLeaseMaterial;
        private System.Windows.Forms.Label lblLeaseSearchMaterial;
        private System.Windows.Forms.TextBox tbLeaseSearchMaterial;
        private System.Windows.Forms.NumericUpDown nudLeaseQuantity;
        private System.Windows.Forms.DateTimePicker dtpLeaseEndDate;
        private System.Windows.Forms.DateTimePicker dtpLeaseStartDate;
        private System.Windows.Forms.Label lblLeaseStartDate;
        private System.Windows.Forms.Label lblLeaseEndDate;
        private System.Windows.Forms.Label lblLeaseQuantity;
        private System.Windows.Forms.Button btnLeaseSearch;
        private System.Windows.Forms.Button btnLeaseLease;
    }
}