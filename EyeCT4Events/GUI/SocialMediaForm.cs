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
        private SocialMediaFrom mediaForm;
        private HomeForm homeForm;

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

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {

        }

        private void SocialMediaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            homeForm.Show();
        }
    }
}
