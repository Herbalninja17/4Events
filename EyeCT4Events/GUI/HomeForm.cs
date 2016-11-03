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
        public HomeForm()
        {
            InitializeComponent();
            lblUserName.Text = Login.loggedinUser.Name;
        }

        private void btnGoToReservation_Click(object sender, EventArgs e)
        {
            MyReservationsForm reservations = new MyReservationsForm();
            reservations.Show();
            this.Close();
        }

        private void btnGoToEvent_Click(object sender, EventArgs e)
        {
            MakeReservationForm makeReservation = new MakeReservationForm();
            makeReservation.Show();
            this.Close();
        }

        private void btnGoToSocialMedia_Click(object sender, EventArgs e)
        {
            SocialMediaForm socialMedia = new SocialMediaForm();
            socialMedia.Show();
            this.Close();
        }

        private void btnGoToLease_Click(object sender, EventArgs e)
        {
            LeaseForm lease = new LeaseForm();
            lease.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
