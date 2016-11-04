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
    public partial class EventBeheerForm : Form
    {
        public EventBeheerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Om naar de form te gaan om een event aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm cef = new CreateEventForm();
            this.Close();
            cef.Show();
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
        /// Om naar de algemene participants form te gaan.
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
