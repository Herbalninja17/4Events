namespace EyeCT4Events
{
    partial class UploadForm
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
            this.btnSocialMediaNewsFeed = new System.Windows.Forms.Button();
            this.btnUploadChooseFile = new System.Windows.Forms.Button();
            this.btnUploadUpload = new System.Windows.Forms.Button();
            this.tbUploadCaption = new System.Windows.Forms.TextBox();
            this.lblUploadCaption = new System.Windows.Forms.Label();
            this.lblChosenFile = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.cbFolders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSocialMediaNewsFeed
            // 
            this.btnSocialMediaNewsFeed.Location = new System.Drawing.Point(24, 23);
            this.btnSocialMediaNewsFeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnSocialMediaNewsFeed.Name = "btnSocialMediaNewsFeed";
            this.btnSocialMediaNewsFeed.Size = new System.Drawing.Size(150, 75);
            this.btnSocialMediaNewsFeed.TabIndex = 2;
            this.btnSocialMediaNewsFeed.Text = "Tijdlijn";
            this.btnSocialMediaNewsFeed.UseVisualStyleBackColor = true;
            this.btnSocialMediaNewsFeed.Click += new System.EventHandler(this.btnSocialMediaNewsFeed_Click);
            // 
            // btnUploadChooseFile
            // 
            this.btnUploadChooseFile.Location = new System.Drawing.Point(606, 96);
            this.btnUploadChooseFile.Margin = new System.Windows.Forms.Padding(6);
            this.btnUploadChooseFile.Name = "btnUploadChooseFile";
            this.btnUploadChooseFile.Size = new System.Drawing.Size(200, 73);
            this.btnUploadChooseFile.TabIndex = 4;
            this.btnUploadChooseFile.Text = "Kies Bestand";
            this.btnUploadChooseFile.UseVisualStyleBackColor = true;
            this.btnUploadChooseFile.Click += new System.EventHandler(this.btnUploadChooseFile_Click);
            // 
            // btnUploadUpload
            // 
            this.btnUploadUpload.Location = new System.Drawing.Point(606, 198);
            this.btnUploadUpload.Margin = new System.Windows.Forms.Padding(6);
            this.btnUploadUpload.Name = "btnUploadUpload";
            this.btnUploadUpload.Size = new System.Drawing.Size(200, 73);
            this.btnUploadUpload.TabIndex = 5;
            this.btnUploadUpload.Text = "Upload";
            this.btnUploadUpload.UseVisualStyleBackColor = true;
            this.btnUploadUpload.Click += new System.EventHandler(this.btnUploadUpload_Click);
            // 
            // tbUploadCaption
            // 
            this.tbUploadCaption.Location = new System.Drawing.Point(486, 23);
            this.tbUploadCaption.Margin = new System.Windows.Forms.Padding(6);
            this.tbUploadCaption.Name = "tbUploadCaption";
            this.tbUploadCaption.Size = new System.Drawing.Size(316, 31);
            this.tbUploadCaption.TabIndex = 6;
            // 
            // lblUploadCaption
            // 
            this.lblUploadCaption.AutoSize = true;
            this.lblUploadCaption.Location = new System.Drawing.Point(339, 26);
            this.lblUploadCaption.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUploadCaption.Name = "lblUploadCaption";
            this.lblUploadCaption.Size = new System.Drawing.Size(135, 25);
            this.lblUploadCaption.TabIndex = 7;
            this.lblUploadCaption.Text = "Beschrijving:";
            // 
            // lblChosenFile
            // 
            this.lblChosenFile.AutoSize = true;
            this.lblChosenFile.Location = new System.Drawing.Point(19, 145);
            this.lblChosenFile.Name = "lblChosenFile";
            this.lblChosenFile.Size = new System.Drawing.Size(74, 25);
            this.lblChosenFile.TabIndex = 8;
            this.lblChosenFile.Text = "(geen)";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(19, 120);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(189, 25);
            this.lblSummary.TabIndex = 9;
            this.lblSummary.Text = "Gekozen Bestand:";
            // 
            // cbFolders
            // 
            this.cbFolders.FormattingEnabled = true;
            this.cbFolders.Location = new System.Drawing.Point(136, 219);
            this.cbFolders.Name = "cbFolders";
            this.cbFolders.Size = new System.Drawing.Size(301, 33);
            this.cbFolders.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categorie:";
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFolders);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblChosenFile);
            this.Controls.Add(this.lblUploadCaption);
            this.Controls.Add(this.tbUploadCaption);
            this.Controls.Add(this.btnUploadUpload);
            this.Controls.Add(this.btnUploadChooseFile);
            this.Controls.Add(this.btnSocialMediaNewsFeed);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UploadForm";
            this.Text = "s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadForm_FormClosing);
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSocialMediaNewsFeed;
        private System.Windows.Forms.Button btnUploadChooseFile;
        private System.Windows.Forms.Button btnUploadUpload;
        private System.Windows.Forms.TextBox tbUploadCaption;
        private System.Windows.Forms.Label lblUploadCaption;
        private System.Windows.Forms.Label lblChosenFile;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.ComboBox cbFolders;
        private System.Windows.Forms.Label label1;
    }
}