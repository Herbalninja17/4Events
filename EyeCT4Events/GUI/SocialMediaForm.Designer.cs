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
            this.btnSocialMediaUpload = new System.Windows.Forms.Button();
            this.lbSocialMedia = new System.Windows.Forms.ListBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSocialMediaUpload
            // 
            this.btnSocialMediaUpload.Location = new System.Drawing.Point(24, 23);
            this.btnSocialMediaUpload.Margin = new System.Windows.Forms.Padding(6);
            this.btnSocialMediaUpload.Name = "btnSocialMediaUpload";
            this.btnSocialMediaUpload.Size = new System.Drawing.Size(150, 75);
            this.btnSocialMediaUpload.TabIndex = 1;
            this.btnSocialMediaUpload.Text = "Upload";
            this.btnSocialMediaUpload.UseVisualStyleBackColor = true;
            this.btnSocialMediaUpload.Click += new System.EventHandler(this.btnSocialMediaUpload_Click);
            // 
            // lbSocialMedia
            // 
            this.lbSocialMedia.FormattingEnabled = true;
            this.lbSocialMedia.ItemHeight = 25;
            this.lbSocialMedia.Location = new System.Drawing.Point(312, 23);
            this.lbSocialMedia.Margin = new System.Windows.Forms.Padding(6);
            this.lbSocialMedia.Name = "lbSocialMedia";
            this.lbSocialMedia.Size = new System.Drawing.Size(958, 754);
            this.lbSocialMedia.TabIndex = 2;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(24, 110);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(6);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(150, 75);
            this.btnMessage.TabIndex = 3;
            this.btnMessage.Text = "Send Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(24, 706);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 75);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(24, 197);
            this.btnShowImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(150, 75);
            this.btnShowImage.TabIndex = 5;
            this.btnShowImage.Text = "Show Image";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(209, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 75);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "↺";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SocialMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 808);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShowImage);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.lbSocialMedia);
            this.Controls.Add(this.btnSocialMediaUpload);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SocialMediaForm";
            this.Text = "Social Media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SocialMediaForm_FormClosing_1);
            this.Load += new System.EventHandler(this.SocialMediaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSocialMediaUpload;
        private System.Windows.Forms.ListBox lbSocialMedia;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.Button btnRefresh;
    }
}