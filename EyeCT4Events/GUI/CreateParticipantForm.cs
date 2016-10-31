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
    public partial class CreateParticipantForm : Form
    {
        public Person person;
        public Maintain maintain = new Maintain();
        public Login login = new Login();

        public CreateParticipantForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Om naar de form te gaan om je account te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditParticipant_Click(object sender, EventArgs e)
        {
            EditParticipantForm epf = new EditParticipantForm();
            this.Close();
            epf.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om je account te verwijderen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Laat de algemene participants form zien.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm participantsform = new ParticipantsForm();
            this.Close();
            participantsform.Show();
        }

        /// <summary>
        /// Maak een nieuw account aan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateParticipantCreateParticipant_Click(object sender, EventArgs e)
        {
            person = new Person(tbCreateParticipantName.Text, dtpCreateParticipantDateOfBirth.Value, tbCreateParticipantCity.Text , tbCreateParticipantZipCode.Text,tbCreateParticipantPhoneNumber.Text, tbCreateParticipantEmail.Text, tbCreateParticipantPassword.Text,tbCreateParticipantRekeningnummer.Text);
            login.CreateUser(person);
        }
    }
}
