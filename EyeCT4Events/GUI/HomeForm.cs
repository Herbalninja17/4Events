using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events.GUI
{
    public partial class HomeForm : Form
    {
        private readonly LoginForm _loginForm;
        public static HomeForm homeForm;

        public HomeForm()
        {
            InitializeComponent();
            lblUserName.Text = Login.loggedinUser.Name;
            homeForm = this;
        }
        public HomeForm(LoginForm loginForm)
        {
            InitializeComponent();
            lblUserName.Text = Login.loggedinUser.Name;
            this._loginForm = loginForm;
            homeForm = this;
        }

        private void btnGoToReservation_Click(object sender, EventArgs e)
        {
            MyReservationsForm reservations = new MyReservationsForm(homeForm);
            reservations.Show();
            this.Hide();
        }

        private void btnGoToEvent_Click(object sender, EventArgs e)
        {
            if (Login.loggedinUser.Admin == 1)
            {
                EventBeheerForm eventForm = new EventBeheerForm(homeForm);
                eventForm.Show();
                this.Hide();
            }
            else
            {
                MakeReservationForm makeReservation = new MakeReservationForm(homeForm);
                makeReservation.Show();
                this.Hide();
            }
        }

        private void btnGoToSocialMedia_Click(object sender, EventArgs e)
        {
            SocialMediaForm socialMedia = new SocialMediaForm(this);
            socialMedia.Show();
            this.Hide();
        }

        private void btnGoToLease_Click(object sender, EventArgs e)
        {
            LeaseForm lease = new LeaseForm(homeForm);
            lease.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            EditParticipantForm epf = new EditParticipantForm();
            this.Hide();
            epf.Show();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.loginForm.Show();  
        }

        private void btnIncheck_Click(object sender, EventArgs e)
        {
            CheckIn check = new CheckIn();
            check.Show();
            this.Hide();
        }
    }
}
