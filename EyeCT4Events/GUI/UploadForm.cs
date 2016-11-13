using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.Data;
using EyeCT4Events.Data.DataClasses;

namespace EyeCT4Events
{
    public partial class UploadForm : Form
    {
        private SocialMediaForm socialMedia;
        private OpenFileDialog chosenFile;

        private List<string> folders;

        public UploadForm()
        {
            InitializeComponent();
        }

        public UploadForm(SocialMediaForm socialMedia)
        {
            InitializeComponent();
            this.socialMedia = socialMedia;
        }

        /// <summary>
        /// Om naar de form te gaan om de feed te bekijken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSocialMediaNewsFeed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Om een file te kiezen om te uploaden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                chosenFile = file;
                lblChosenFile.Text = chosenFile.FileName;
            }
        }

        /// <summary>
        /// Upload de geselecteerde file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadUpload_Click(object sender, EventArgs e)
        {
            if (chosenFile == null)
            {
                MessageBox.Show("U heeft geen bestand geselecteerd.");
                return;
            }

            File uploadFile = new File(tbUploadCaption.Text, chosenFile.FileName, Login.loggedinUser);
            string selectedFolder = cbFolders.SelectedItem.ToString();
            uploadFile.Upload(selectedFolder);
            this.Close();
        }

        private void UploadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            socialMedia.Refresh();
            socialMedia.Show();
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            folders = DataFile.GetFolders();
            foreach (string folder in folders)
            {
                cbFolders.Items.Add(folder);
            }
        }
    }
}
