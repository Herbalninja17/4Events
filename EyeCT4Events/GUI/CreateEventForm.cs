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
        public CreateEventForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Om een nieuw event aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEventCreateEvent_Click(object sender, EventArgs e)
        {
            Camping camping = cbCreateEventCamping.SelectedItem as Camping;
            if (camping == null) { MessageBox.Show("Geen geldige camping gesellecteerd."); return; }

            if (String.IsNullOrWhiteSpace(tbCreateEventName.Text) || dtpBeginDate.Value <= DateTime.Now || 
                dtpEndDate.Value < dtpBeginDate.Value || cbCreateEventCamping.SelectedIndex == -1)
            { MessageBox.Show("Vul alle velden correct in."); return; }

            //MOETEN EERST CAMPINGS KUNNEN WORDEN BINNEN GEHAALD UIT DE DATABASE IN IN DE COMBOBOX WORDEN GEPLAATS OM DEZE
            //METHODE AF TE MAKEN!!!!

            //Event newEvent = new Event(tbCreateEventName.Text, address, dtpBeginDate.Value, dtpEndDate.Value, maxVisitors,)
            //Data.DataClasses.DataEvent.SetEvent(newEvent);
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
    }
}
