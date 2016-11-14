using EyeCT4Events.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.Data.DataClasses;

namespace EyeCT4Events
{
    public partial class SocialMediaForm : Form
    {
        private SocialMediaForm mediaForm;
        private HomeForm homeForm;
        private List<File> fileList;

        public SocialMediaForm()
        {
            InitializeComponent();
            mediaForm = this;
        }

        public SocialMediaForm(HomeForm homeForm)
        {
            InitializeComponent();
            mediaForm = this;
            this.homeForm = homeForm;
        }

        /// <summary>
        /// Om naar de form te gaan om media te uploaden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSocialMediaUpload_Click(object sender, EventArgs e)
        {
            UploadForm upload = new UploadForm(mediaForm);
            upload.Show();
            this.Hide();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (lbSocialMedia.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een post om een bericht erover te sturen.");
            }
            else
            {
                int index = lbSocialMedia.SelectedIndex;
                File file = fileList[index];
                MessageForm msgForm = new MessageForm(file);
                msgForm.Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeForm = new HomeForm();
            this.Close();
        }

        private void SocialMediaForm_Load(object sender, EventArgs e)
        {
            MediaListRefresh();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            int index = lbSocialMedia.SelectedIndex;
            int fileId = fileList[index].FileID;

            ImageForm imgForm = new ImageForm(fileId);
            imgForm.Show();
        }

        private void SocialMediaForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            HomeForm.homeForm.Show();
        }

        private void MediaListRefresh()
        {
            fileList = DataFile.GetFileList();
            foreach (File f in fileList)
            {
                string catName = DataFile.GetFolderName(f.FileID);

                lbSocialMedia.Items.Add($"Poster: {f.Poster.Name}    Titel: {f.FileName}    Cat.: {catName}    Type: {f.FileType}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbSocialMedia.Items.Clear();
            MediaListRefresh();
        }
    }
}