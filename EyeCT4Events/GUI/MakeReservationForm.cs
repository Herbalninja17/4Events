using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.GUI;
using EyeCT4Events.Data.DataClasses;

namespace EyeCT4Events
{
    public partial class MakeReservationForm : Form
    {
        private HomeForm homeForm;
        private MakeReservationForm makeReservationForm;

        public MakeReservationForm()
        {
            InitializeComponent();
            makeReservationForm = this;
        }

        public MakeReservationForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            makeReservationForm = this;
        }

        /// <summary>
        /// Geef de form om een locatie te selecteren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationsLocation_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm();
            mapForm.Show();
        }

        /// <summary>
        /// Om je reservaties te bekijken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationsReservations_Click(object sender, EventArgs e)
        {
            string x = lbReservationEvents.SelectedItem.ToString();
            
            Data.DataClasses.DataReservation.SetReservation(Reservation.Map, "Niet betaald", dtpReservationBeginDate.Text, dtpReservationEndDate.Text, x[0].ToString());

            MyReservationsForm reservationForm = new MyReservationsForm(makeReservationForm);
            reservationForm.Show();
            this.Close();
        }

        /// <summary>
        /// Maakt een nieuwe reservering aan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        

        private void btnReservationsMakeReservation_Click(object sender, EventArgs e)
        {
            

            //Alle info inladen en opsturen naar de Data klasse, hierin verwerken tot een format dat in de database past.
        }

        /// <summary>
        /// Zoeken naar participanten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationSearchParticipant_Click(object sender, EventArgs e)
        {
            //Eventueel algemeen zoekForm aanmaken, dan met parameter ervoor zorgen dat het juiste attribuut gezocht wordt.
            List<int> accountid = Data.DataClasses.DataPerson.GetSearchedPerson(tbReservationSearchParticipant.Text);

        }

        /// <summary>
        /// Om een participant aan je reservering toe te voegen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationAddParticipant_Click(object sender, EventArgs e)
        {
            //Geselecteerde deelnemer toevoegen.
        }

        /// <summary>
        /// Om naar de algemene particiapants form te gaan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm participantsForm = new ParticipantsForm(makeReservationForm);
            this.Hide();
            participantsForm.Show();
        }

        private void MakeReservationForm_Load(object sender, EventArgs e)
        {
            DataEvent.GetEvent();
            foreach (string i in DataEvent.events)
            {
                lbReservationEvents.Items.Add(i);
            }
        }
    }
}
