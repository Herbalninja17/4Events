namespace EyeCT4Events
{
    partial class SocialMediaForm
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
            this.btnSocialMediaUpload = new System.Windows.Forms.Button();
            this.lbSocialMedia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSocialMediaNewsFeed
            // 
            this.btnSocialMediaNewsFeed.Location = new System.Drawing.Point(12, 12);
            this.btnSocialMediaNewsFeed.Name = "btnSocialMediaNewsFeed";
            this.btnSocialMediaNewsFeed.Size = new System.Drawing.Size(75, 39);
            this.btnSocialMediaNewsFeed.TabIndex = 0;
            this.btnSocialMediaNewsFeed.Text = "News Feed";
            this.btnSocialMediaNewsFeed.UseVisualStyleBackColor = true;
            this.btnSocialMediaNewsFeed.Click += new System.EventHandler(this.btnSocialMediaNewsFeed_Click);
            // 
            // btnSocialMediaUpload
            // 
            this.btnSocialMediaUpload.Location = new System.Drawing.Point(12, 71);
            this.btnSocialMediaUpload.Name = "btnSocialMediaUpload";
            this.btnSocialMediaUpload.Size = new System.Drawing.Size(75, 39);
            this.btnSocialMediaUpload.TabIndex = 1;
            this.btnSocialMediaUpload.Text = "Upload";
            this.btnSocialMediaUpload.UseVisualStyleBackColor = true;
            this.btnSocialMediaUpload.Click += new System.EventHandler(this.btnSocialMediaUpload_Click);
            // 
            // lbSocialMedia
            // 
            this.lbSocialMedia.FormattingEnabled = true;
            this.lbSocialMedia.Location = new System.Drawing.Point(156, 12);
            this.lbSocialMedia.Name = "lbSocialMedia";
            this.lbSocialMedia.Size = new System.Drawing.Size(481, 394);
            this.lbSocialMedia.TabIndex = 2;
            // 
            // SocialMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 420);
            this.Controls.Add(this.lbSocialMedia);
            this.Controls.Add(this.btnSocialMediaUpload);
            this.Controls.Add(this.btnSocialMediaNewsFeed);
            this.Name = "SocialMediaForm";
            this.Text = "Social Media";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSocialMediaNewsFeed;
        private System.Windows.Forms.Button btnSocialMediaUpload;
        private System.Windows.Forms.ListBox lbSocialMedia;
    }
}