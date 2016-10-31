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
            this.SuspendLayout();
            // 
            // btnSocialMediaNewsFeed
            // 
            this.btnSocialMediaNewsFeed.Location = new System.Drawing.Point(12, 12);
            this.btnSocialMediaNewsFeed.Name = "btnSocialMediaNewsFeed";
            this.btnSocialMediaNewsFeed.Size = new System.Drawing.Size(75, 39);
            this.btnSocialMediaNewsFeed.TabIndex = 2;
            this.btnSocialMediaNewsFeed.Text = "News Feed";
            this.btnSocialMediaNewsFeed.UseVisualStyleBackColor = true;
            this.btnSocialMediaNewsFeed.Click += new System.EventHandler(this.btnSocialMediaNewsFeed_Click);
            // 
            // btnUploadChooseFile
            // 
            this.btnUploadChooseFile.Location = new System.Drawing.Point(303, 50);
            this.btnUploadChooseFile.Name = "btnUploadChooseFile";
            this.btnUploadChooseFile.Size = new System.Drawing.Size(100, 38);
            this.btnUploadChooseFile.TabIndex = 4;
            this.btnUploadChooseFile.Text = "Choose File";
            this.btnUploadChooseFile.UseVisualStyleBackColor = true;
            this.btnUploadChooseFile.Click += new System.EventHandler(this.btnUploadChooseFile_Click);
            // 
            // btnUploadUpload
            // 
            this.btnUploadUpload.Location = new System.Drawing.Point(303, 103);
            this.btnUploadUpload.Name = "btnUploadUpload";
            this.btnUploadUpload.Size = new System.Drawing.Size(100, 38);
            this.btnUploadUpload.TabIndex = 5;
            this.btnUploadUpload.Text = "Upload";
            this.btnUploadUpload.UseVisualStyleBackColor = true;
            this.btnUploadUpload.Click += new System.EventHandler(this.btnUploadUpload_Click);
            // 
            // tbUploadCaption
            // 
            this.tbUploadCaption.Location = new System.Drawing.Point(243, 12);
            this.tbUploadCaption.Name = "tbUploadCaption";
            this.tbUploadCaption.Size = new System.Drawing.Size(160, 20);
            this.tbUploadCaption.TabIndex = 6;
            // 
            // lblUploadCaption
            // 
            this.lblUploadCaption.AutoSize = true;
            this.lblUploadCaption.Location = new System.Drawing.Point(174, 15);
            this.lblUploadCaption.Name = "lblUploadCaption";
            this.lblUploadCaption.Size = new System.Drawing.Size(46, 13);
            this.lblUploadCaption.TabIndex = 7;
            this.lblUploadCaption.Text = "Caption:";
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 164);
            this.Controls.Add(this.lblUploadCaption);
            this.Controls.Add(this.tbUploadCaption);
            this.Controls.Add(this.btnUploadUpload);
            this.Controls.Add(this.btnUploadChooseFile);
            this.Controls.Add(this.btnSocialMediaNewsFeed);
            this.Name = "UploadForm";
            this.Text = "Upload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSocialMediaNewsFeed;
        private System.Windows.Forms.Button btnUploadChooseFile;
        private System.Windows.Forms.Button btnUploadUpload;
        private System.Windows.Forms.TextBox tbUploadCaption;
        private System.Windows.Forms.Label lblUploadCaption;
    }
}