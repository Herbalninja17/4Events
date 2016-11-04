using EyeCT4Events.Data.DataClasses;
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
    public partial class EditEventForm : Form
    {
        private EditEventForm editEvent;
        private EventBeheerForm eventForm;
        private List<Event> Events;

        private static Event selectedEvent;

        public EditEventForm()
        {
            InitializeComponent();
        }

        public EditEventForm(EventBeheerForm eventForm)
        {
            InitializeComponent();
            editEvent = this;
            this.eventForm = eventForm;

            Events = DataEvent.GetEventList();
            foreach(Event found in Events)
            {
                lbEditEvent.Items.Add(found);
            }
        }

        /// <summary>
        /// Om het event te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEventEditEvent_Click(object sender, EventArgs e)
        {
            if(selectedEvent != null)
            {
                if(String.IsNullOrWhiteSpace(tbEditEventName.Text) || dtpEditBeginDate.Value < DateTime.Today || dtpEditBeginDate.Value < dtpEditBeginDate.Value)
                { MessageBox.Show("Vul geldige waarden in voor de naam en data. (start datum mag niet eerder dan vandaag zijn)."); return; }

                selectedEvent.Name = tbEditEventName.Text;
                selectedEvent.StartDate = dtpEditBeginDate.Value;
                selectedEvent.EndDate = dtpEditEndDate.Value;

                DataEvent.UpdateEvent(selectedEvent);
                MessageBox.Show("Updated Event.");
            }
        }

        /// <summary>
        /// Zoeken naar een event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEventSearch_Click(object sender, EventArgs e)
        {
            lbEditEvent.Items.Clear();
            Events.Clear();

            if(String.IsNullOrWhiteSpace(tbSearchEditEventName.Text))
            {
                //List with all events
                Events = DataEvent.GetEventList();
            }
            else
            {
                //Lists with events containing the search term or part of it.
                Events = DataEvent.SearchEvents(tbSearchEditEventName.Text);
            }

            foreach (Event found in Events)
            {
                lbEditEvent.Items.Add(found);
            }
        }

        /// <summary>
        /// Om naar de form te gaan om een event aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm cef = new CreateEventForm();
            this.Hide();
            cef.Show();
        }

        /// <summary>
        /// Om naar de algemene participants form te gaan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm pf = new ParticipantsForm();
            this.Hide();
            pf.Show();
        }

        /// <summary>
        /// Om een opgezochte event te selecteren om te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEventSelectEvent_Click(object sender, EventArgs e)
        {
            selectedEvent = lbEditEvent.SelectedItem as Event;
            if (selectedEvent != null)
            {
                tbEditEventName.Text = selectedEvent.Name;
                tbEditEventStreet.Text = selectedEvent.Camping.Address;
                tbEditEventCity.Text = selectedEvent.Camping.City;
                tbEditEventZipCode.Text = selectedEvent.Camping.Zipcode;
                dtpEditBeginDate.Value = selectedEvent.StartDate;
                dtpEditEndDate.Value = selectedEvent.EndDate;
                tbEditEventCapacity.Text = selectedEvent.Camping.Places.ToString();
            }

        }

        private void EditEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            eventForm.Show();
        }
    }
}
