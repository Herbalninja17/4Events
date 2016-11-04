namespace EyeCT4Events
{
    partial class CreateEventForm
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
            this.lblCreateEventName = new System.Windows.Forms.Label();
            this.lblCreateEventBeginDate = new System.Windows.Forms.Label();
            this.lblCreateEventEndDate = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbCreateEventName = new System.Windows.Forms.TextBox();
            this.btnCreateEventCreateEvent = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cbCreateEventCamping = new System.Windows.Forms.ComboBox();
            this.lblCreateEventCamping = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreateEventName
            // 
            this.lblCreateEventName.AutoSize = true;
            this.lblCreateEventName.Location = new System.Drawing.Point(14, 14);
            this.lblCreateEventName.Name = "lblCreateEventName";
            this.lblCreateEventName.Size = new System.Drawing.Size(95, 13);
            this.lblCreateEventName.TabIndex = 0;
            this.lblCreateEventName.Text = "Evenement Naam:";
            // 
            // lblCreateEventBeginDate
            // 
            this.lblCreateEventBeginDate.AutoSize = true;
            this.lblCreateEventBeginDate.Location = new System.Drawing.Point(14, 40);
            this.lblCreateEventBeginDate.Name = "lblCreateEventBeginDate";
            this.lblCreateEventBeginDate.Size = new System.Drawing.Size(71, 13);
            this.lblCreateEventBeginDate.TabIndex = 5;
            this.lblCreateEventBeginDate.Text = "Begin Datum:";
            // 
            // lblCreateEventEndDate
            // 
            this.lblCreateEventEndDate.AutoSize = true;
            this.lblCreateEventEndDate.Location = new System.Drawing.Point(14, 65);
            this.lblCreateEventEndDate.Name = "lblCreateEventEndDate";
            this.lblCreateEventEndDate.Size = new System.Drawing.Size(65, 13);
            this.lblCreateEventEndDate.TabIndex = 6;
            this.lblCreateEventEndDate.Text = "Eind Datum:";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(131, 37);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDate.TabIndex = 8;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(131, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // tbCreateEventName
            // 
            this.tbCreateEventName.Location = new System.Drawing.Point(131, 11);
            this.tbCreateEventName.Name = "tbCreateEventName";
            this.tbCreateEventName.Size = new System.Drawing.Size(200, 20);
            this.tbCreateEventName.TabIndex = 10;
            // 
            // btnCreateEventCreateEvent
            // 
            this.btnCreateEventCreateEvent.Location = new System.Drawing.Point(256, 119);
            this.btnCreateEventCreateEvent.Name = "btnCreateEventCreateEvent";
            this.btnCreateEventCreateEvent.Size = new System.Drawing.Size(75, 40);
            this.btnCreateEventCreateEvent.TabIndex = 16;
            this.btnCreateEventCreateEvent.Text = "Evenement Aanmaken";
            this.btnCreateEventCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEventCreateEvent.Click += new System.EventHandler(this.btnCreateEventCreateEvent_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 119);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 43);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // cbCreateEventCamping
            // 
            this.cbCreateEventCamping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreateEventCamping.FormattingEnabled = true;
            this.cbCreateEventCamping.Location = new System.Drawing.Point(131, 92);
            this.cbCreateEventCamping.Name = "cbCreateEventCamping";
            this.cbCreateEventCamping.Size = new System.Drawing.Size(200, 21);
            this.cbCreateEventCamping.TabIndex = 21;
            // 
            // lblCreateEventCamping
            // 
            this.lblCreateEventCamping.AutoSize = true;
            this.lblCreateEventCamping.Location = new System.Drawing.Point(14, 95);
            this.lblCreateEventCamping.Name = "lblCreateEventCamping";
            this.lblCreateEventCamping.Size = new System.Drawing.Size(51, 13);
            this.lblCreateEventCamping.TabIndex = 22;
            this.lblCreateEventCamping.Text = "Camping:";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 167);
            this.Controls.Add(this.lblCreateEventCamping);
            this.Controls.Add(this.cbCreateEventCamping);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCreateEventCreateEvent);
            this.Controls.Add(this.tbCreateEventName);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.lblCreateEventEndDate);
            this.Controls.Add(this.lblCreateEventBeginDate);
            this.Controls.Add(this.lblCreateEventName);
            this.Name = "CreateEventForm";
            this.Text = "Create Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEventForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateEventName;
        private System.Windows.Forms.Label lblCreateEventBeginDate;
        private System.Windows.Forms.Label lblCreateEventEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox tbCreateEventName;
        private System.Windows.Forms.Button btnCreateEventCreateEvent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cbCreateEventCamping;
        private System.Windows.Forms.Label lblCreateEventCamping;
    }
}