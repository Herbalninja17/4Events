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
            this.btnLease = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudLeaseQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHired
            // 
            this.btnHired.Location = new System.Drawing.Point(12, 70);
            this.btnHired.Name = "btnHired";
            this.btnHired.Size = new System.Drawing.Size(75, 36);
            this.btnHired.TabIndex = 3;
            this.btnHired.Text = "Hired";
            this.btnHired.UseVisualStyleBackColor = true;
            this.btnHired.Click += new System.EventHandler(this.btnHired_Click);
            // 
            // btnLease
            // 
            this.btnLease.Location = new System.Drawing.Point(12, 12);
            this.btnLease.Name = "btnLease";
            this.btnLease.Size = new System.Drawing.Size(75, 36);
            this.btnLease.TabIndex = 2;
            this.btnLease.Text = "Lease";
            this.btnLease.UseVisualStyleBackColor = true;
            this.btnLease.Click += new System.EventHandler(this.btnLease_Click);
            // 
            // lbLeaseMaterial
            // 
            this.lbLeaseMaterial.FormattingEnabled = true;
            this.lbLeaseMaterial.Location = new System.Drawing.Point(12, 124);
            this.lbLeaseMaterial.Name = "lbLeaseMaterial";
            this.lbLeaseMaterial.Size = new System.Drawing.Size(748, 212);
            this.lbLeaseMaterial.TabIndex = 4;
            // 
            // lblLeaseSearchMaterial
            // 
            this.lblLeaseSearchMaterial.AutoSize = true;
            this.lblLeaseSearchMaterial.Location = new System.Drawing.Point(491, 56);
            this.lblLeaseSearchMaterial.Name = "lblLeaseSearchMaterial";
            this.lblLeaseSearchMaterial.Size = new System.Drawing.Size(84, 13);
            this.lblLeaseSearchMaterial.TabIndex = 5;
            this.lblLeaseSearchMaterial.Text = "Search Material:";
            // 
            // tbLeaseSearchMaterial
            // 
            this.tbLeaseSearchMaterial.Location = new System.Drawing.Point(581, 53);
            this.tbLeaseSearchMaterial.Name = "tbLeaseSearchMaterial";
            this.tbLeaseSearchMaterial.Size = new System.Drawing.Size(179, 20);
            this.tbLeaseSearchMaterial.TabIndex = 6;
            // 
            // nudLeaseQuantity
            // 
            this.nudLeaseQuantity.Location = new System.Drawing.Point(281, 80);
            this.nudLeaseQuantity.Name = "nudLeaseQuantity";
            this.nudLeaseQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudLeaseQuantity.TabIndex = 7;
            // 
            // dtpLeaseEndDate
            // 
            this.dtpLeaseEndDate.Location = new System.Drawing.Point(281, 47);
            this.dtpLeaseEndDate.Name = "dtpLeaseEndDate";
            this.dtpLeaseEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLeaseEndDate.TabIndex = 8;
            // 
            // dtpLeaseStartDate
            // 
            this.dtpLeaseStartDate.Location = new System.Drawing.Point(281, 12);
            this.dtpLeaseStartDate.Name = "dtpLeaseStartDate";
            this.dtpLeaseStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLeaseStartDate.TabIndex = 9;
            // 
            // lblLeaseStartDate
            // 
            this.lblLeaseStartDate.AutoSize = true;
            this.lblLeaseStartDate.Location = new System.Drawing.Point(184, 18);
            this.lblLeaseStartDate.Name = "lblLeaseStartDate";
            this.lblLeaseStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblLeaseStartDate.TabIndex = 10;
            this.lblLeaseStartDate.Text = "Start Date:";
            // 
            // lblLeaseEndDate
            // 
            this.lblLeaseEndDate.AutoSize = true;
            this.lblLeaseEndDate.Location = new System.Drawing.Point(184, 53);
            this.lblLeaseEndDate.Name = "lblLeaseEndDate";
            this.lblLeaseEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblLeaseEndDate.TabIndex = 11;
            this.lblLeaseEndDate.Text = "End Date:";
            // 
            // lblLeaseQuantity
            // 
            this.lblLeaseQuantity.AutoSize = true;
            this.lblLeaseQuantity.Location = new System.Drawing.Point(184, 82);
            this.lblLeaseQuantity.Name = "lblLeaseQuantity";
            this.lblLeaseQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblLeaseQuantity.TabIndex = 12;
            this.lblLeaseQuantity.Text = "Quantity:";
            // 
            // btnLeaseSearch
            // 
            this.btnLeaseSearch.Location = new System.Drawing.Point(685, 82);
            this.btnLeaseSearch.Name = "btnLeaseSearch";
            this.btnLeaseSearch.Size = new System.Drawing.Size(75, 36);
            this.btnLeaseSearch.TabIndex = 13;
            this.btnLeaseSearch.Text = "Search";
            this.btnLeaseSearch.UseVisualStyleBackColor = true;
            this.btnLeaseSearch.Click += new System.EventHandler(this.btnLeaseSearch_Click);
            // 
            // LeaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 351);
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
            this.Controls.Add(this.btnLease);
            this.Name = "LeaseForm";
            this.Text = "Lease";
            ((System.ComponentModel.ISupportInitialize)(this.nudLeaseQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHired;
        private System.Windows.Forms.Button btnLease;
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
    }
}