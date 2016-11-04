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
        private HomeForm homeForm;
        private List<Camping> Campings;

        public CreateEventForm()
        {
            InitializeComponent();
            createEvent = this;           
        }

        public CreateEventForm(HomeForm homeForm)
        {
            InitializeComponent();
            createEvent = this;
            this.homeForm = homeForm;
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
        }

        /// <summary>
        /// Om naar de algemene participants form te gaan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            //DeleteEventForm def = new DeleteEventForm();
            HomeForm home = new HomeForm();
            this.Close();
            home.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om een event te verwijderen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            //DeleteEventForm def = new DeleteEventForm();
            //this.Close();
            //def.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om een event te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            EditEventForm eef = new EditEventForm();
            this.Close();
            eef.Show();
        }

        private void CreateEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Show();
        }
    }
}
