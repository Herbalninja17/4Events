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
    public partial class MakeReservationForm : Form
    {
        public MakeReservationForm()
        {
            InitializeComponent();
        }

        private void btnReservationsLocation_Click(object sender, EventArgs e)
        {
            MapForm mf = new MapForm();
            mf.Show();
        }

        private void btnReservationsReservations_Click(object sender, EventArgs e)
        {

        }

        private void btnReservationsMakeReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnReservationSearchParticipant_Click(object sender, EventArgs e)
        {

        }

        private void btnReservationAddParticipant_Click(object sender, EventArgs e)
        {

        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm pf = new ParticipantsForm();
            this.Hide();
            pf.Show();
        }
    }
}
