using EyeCT4Events.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string fn = Convert.ToString(lbSocialMedia.SelectedItem);
                int fileID = Convert.ToInt32(fn.Substring(0, fn.IndexOf(" ")));
                foreach (File f in fileList)
                {
                    if (fileID == f.FileID)
                    {
                        MessageForm mf = new MessageForm(f);
                        mf.Show();
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeForm = new HomeForm();
            this.Close();
        }

        private void SocialMediaForm_Load(object sender, EventArgs e)
        {
            fileList = Data.DataClasses.DataFile.GetFileList();
            foreach(File f in fileList)
            {
                lbSocialMedia.Items.Add(f.FileID + " Gepost door: " + f.Poster.Name + " Bestandsnaam: " + f.FileName + " Bestandstype: " + f.FileType);
            }
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
    }
}