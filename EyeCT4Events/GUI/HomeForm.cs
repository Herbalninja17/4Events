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
        private HomeForm homeForm;

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
                CreateEventForm createEvent = new CreateEventForm(homeForm);
                createEvent.Show();
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
            SocialMediaForm socialMedia = new SocialMediaForm();
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
            _loginForm.Show();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
