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

        /// <summary>
        /// Geef de form om een locatie te selecteren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationsLocation_Click(object sender, EventArgs e)
        {
            MapForm mf = new MapForm();
            mf.Show();
        }

        /// <summary>
        /// Om je reservaties te bekijken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationsReservations_Click(object sender, EventArgs e)
        {
            MyReservationsForm mrf = new MyReservationsForm();
            mrf.Show();
        }

        /// <summary>
        /// Maakt een nieuwe reservering aan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationsMakeReservation_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Zoeken naar participanten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationSearchParticipant_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Om een participant aan je reservering toe te voegen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationAddParticipant_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Om naar de algemene particiapants form te gaan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm pf = new ParticipantsForm();
            this.Close();
            pf.Show();
        }
    }
}
