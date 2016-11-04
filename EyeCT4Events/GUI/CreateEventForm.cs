using EyeCT4Events.Data.DataClasses;
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
    public partial class CreateEventForm : Form
    {
        private CreateEventForm createEvent;
        private EventBeheerForm eventForm;
        private List<Camping> Campings;

        public CreateEventForm()
        {
            InitializeComponent();
            createEvent = this;           
        }

        public CreateEventForm(EventBeheerForm eventForm)
        {
            InitializeComponent();
            createEvent = this;
            this.eventForm = eventForm;
            Campings = DataCamping.GetCampingList();

            foreach (Camping found in Campings)
            {
                cbCreateEventCamping.Items.Add(found.Name);
            }
        }

        /// <summary>
        /// Om een nieuw event aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEventCreateEvent_Click(object sender, EventArgs e)
        {
            Camping camping = null;
            if(cbCreateEventCamping.SelectedIndex != -1)
            {
                foreach(Camping found in Campings)
                {
                    if(found.Name == cbCreateEventCamping.SelectedItem.ToString())
                    {
                        camping = found;
                    }
                }
            }
            if (camping == null) { MessageBox.Show("Geen geldige camping gesellecteerd."); return; }

            if (String.IsNullOrWhiteSpace(tbCreateEventName.Text) || dtpBeginDate.Value <= DateTime.Today || 
                dtpEndDate.Value < dtpBeginDate.Value) { MessageBox.Show("Vul alle velden correct in."); return; }

            Event Event = new Event(tbCreateEventName.Text, dtpBeginDate.Value, dtpEndDate.Value, camping);

            DataEvent.SetEvent(Event);
            MessageBox.Show("Event was created.");
        }

        private void CreateEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            eventForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            eventForm.Show();
        }
    }
}
