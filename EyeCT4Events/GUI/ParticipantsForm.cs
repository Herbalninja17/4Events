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
    public partial class ParticipantsForm : Form
    {
        private ParticipantsForm participantsForm;
        private MakeReservationForm reservationForm;

        public ParticipantsForm()
        {
            InitializeComponent();
            participantsForm = this;
        }

        public ParticipantsForm(MakeReservationForm reservationForm)
        {
            InitializeComponent();
            participantsForm = this;
            this.reservationForm = reservationForm;
        }

        /// <summary>
        /// Om naar de form te gaan om een nieuw account aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateParticipant_Click(object sender, EventArgs e)
        {
            CreateParticipantForm createForm = new CreateParticipantForm(participantsForm);
            createForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Om naar de form te gaan om je account te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditParticipant_Click(object sender, EventArgs e)
        {
            EditParticipantForm editForm = new EditParticipantForm();
            editForm.Show();
            this.Close();
        }

        /// <summary>
        /// Om naar de form te gaan om je account te verwijderen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            //Zoekscherm aanmaken met delete en annuleer knop.
        }

        /// <summary>
        /// Om naar de form te gaan om een reservering te plaatsen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvents_Click(object sender, EventArgs e)
        {
            MakeReservationForm reservationForm = new MakeReservationForm();
            reservationForm.Show();
            this.Close();
        }

        /// <summary>
        /// Om naar de form te gaan om materiaal te huren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaterial_Click(object sender, EventArgs e)
        {
            HiredMaterialForm hiredMaterialForm = new HiredMaterialForm();
            hiredMaterialForm.Show();
            this.Close();
        }
    }
}
