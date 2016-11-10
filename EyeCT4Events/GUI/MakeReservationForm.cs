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
        private List<Person> searchedperson;
        Reservation reservation;
        private bool begindatechanged = false;
        private bool enddatechanged = false;

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
            MapForm.begindate = dtpReservationBeginDate.Value.ToShortDateString();
            MapForm.enddate = dtpReservationEndDate.Value.ToShortDateString();
            this.Close();
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
            //string x = lbReservationEvents.SelectedItem.ToString();

            //Data.DataClasses.DataReservation.SetReservation(Reservation.Map, "Niet betaald", dtpReservationBeginDate.Text, dtpReservationEndDate.Text, x[0].ToString());

            HomeForm hf = new HomeForm();
            hf.Show();
            this.Close();
        }

        /// <summary>
        /// Maakt een nieuwe reservering aan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationsMakeReservation_Click(object sender, EventArgs e)
        {
            reservation.BeginDate = dtpReservationBeginDate.Value;
            reservation.EndDate = dtpReservationEndDate.Value;
            if (reservation.BeginDate > reservation.EndDate)
            {
                MessageBox.Show("De begin datum kan niet later zijn dan de eind datum!");
            }
            else
            {
                string eventids = Convert.ToString(lbReservationEvents.SelectedItem);
                string eventid = eventids.Split(')')[0];
                if (Reservation.Map != 0 && eventid != null)
                {
                    if (Data.DataClasses.DataReservation.SetReservation(Reservation.Map, "Niet betaald", reservation.BeginDate.ToShortDateString(), reservation.EndDate.ToShortDateString(), eventid))
                    {
                        MessageBox.Show("Reservering is aangemaakt!");
                        HomeForm hf = new HomeForm();
                        this.Close();
                        hf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Reservering is niet aangemaakt!");
                    }
                }
            }

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
            searchedperson = Data.DataClasses.DataPerson.GetSearchedPerson(tbReservationSearchParticipant.Text);
            foreach(Person p in searchedperson)
            {
                lbReservationParticipants.Items.Add(p.Email);
            }
        }

        /// <summary>
        /// Om een participant aan je reservering toe te voegen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationAddParticipant_Click(object sender, EventArgs e)
        {
            //Geselecteerde deelnemer toevoegen.
            Person selectedperson = new Person(Convert.ToString(lbReservationParticipants.SelectedItem));
            if (reservation.AddPerson(selectedperson))
            {
                lbReservationPeopleInReservation.Items.Add(selectedperson.Email);
                MessageBox.Show("Persoon is toegevoegd.");
            }
            else
            {
                MessageBox.Show("Persoon is niet toegevoegd.");
            }
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
            lbReservationEvents.Items.Clear();

            DataEvent.GetEvent();
            
            foreach (string i in DataEvent.events)
            {
                lbReservationEvents.Items.Add(i);
            }
            btnReservationsLocation.Visible = false;
            btnReservationsLocation.Enabled = false;
            btnReservationAddParticipant.Visible = false;
            btnReservationAddParticipant.Enabled = false;
            btnReservationSearchParticipant.Visible = false;
            btnReservationSearchParticipant.Enabled = false;
            btnReservationsMakeReservation.Visible = false;
            btnReservationsMakeReservation.Enabled = false;
            lbReservationParticipants.Enabled = false;
            lbReservationParticipants.Visible = false;
            tbReservationSearchParticipant.Visible = false;
            tbReservationSearchParticipant.Enabled = false;
            if (Reservation.Map > 0)
            {
                Reservation.Capacity = DataCampingSpot.GetCampingSpotCapacity(Reservation.Map);
                if (Reservation.Capacity > 0)
                {
                    dtpReservationBeginDate.Value = DateTime.Parse(MapForm.begindate);
                    dtpReservationEndDate.Value = DateTime.Parse(MapForm.enddate);

                    reservation = new Reservation(dtpReservationBeginDate.Value, dtpReservationEndDate.Value);
                    if (reservation.AddPerson(Login.loggedinUser))
                    {
                        MessageBox.Show("U bent toegevoegd aan de reservering.");
                        lbReservationPeopleInReservation.Items.Add(Login.loggedinUser.Email);
                    }
                    else
                    {
                        MessageBox.Show("U bent niet toegevoegd aan uw reservering, zoek uzelf op en voeg uzelf toe aan de reservering.");
                    }

                    lblReservations.Visible = false;
                    btnReservationAddParticipant.Visible = true;
                    btnReservationAddParticipant.Enabled = true;
                    btnReservationSearchParticipant.Visible = true;
                    btnReservationSearchParticipant.Enabled = true;
                    btnReservationsMakeReservation.Visible = true;
                    btnReservationsMakeReservation.Enabled = true;
                    lbReservationParticipants.Enabled = true;
                    lbReservationParticipants.Visible = true;
                    tbReservationSearchParticipant.Visible = true;
                    tbReservationSearchParticipant.Enabled = true;
                }
            }
        }

        private void dtpReservationBeginDate_ValueChanged(object sender, EventArgs e)
        {
            begindatechanged = true;
            if(begindatechanged && enddatechanged)
            {
                btnReservationsLocation.Visible = true;
                btnReservationsLocation.Enabled = true;
                lblReservations.Visible = false;
            }

        }

        private void dtpReservationEndDate_ValueChanged(object sender, EventArgs e)
        {
            enddatechanged = true;
            if (begindatechanged && enddatechanged)
            {
                btnReservationsLocation.Visible = true;
                btnReservationsLocation.Enabled = true;
                lblReservations.Visible = false;
            }
        }
    }
}
