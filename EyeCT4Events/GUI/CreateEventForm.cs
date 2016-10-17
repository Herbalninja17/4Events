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

        }

        /// <summary>
        /// Om naar de algemene participants form te gaan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Om naar de form te gaan om een event te verwijderen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DeleteEventForm def = new DeleteEventForm();
            this.Hide();
            def.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om een event te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            
        }
    }
}
