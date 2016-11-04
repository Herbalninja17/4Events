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
    public partial class CreateParticipantForm : Form
    {
        public Person person;
        public Maintain maintain = new Maintain();
        public Login login = new Login();

        private CreateParticipantForm createForm;
        private ParticipantsForm participantsForm;
        private HomeForm homeform;

        public CreateParticipantForm()
        {
            InitializeComponent();
            SetTextboxes();
            createForm = this;
        }

        public CreateParticipantForm(ParticipantsForm participantsForm)
        {
            InitializeComponent();
            SetTextboxes();
            createForm = this;
            this.participantsForm = participantsForm;
        }

        private void SetTextboxes()
        {
            //btnEditParticipant.Enabled = false;
            //btnDeleteParticipant.Enabled = false;
        }

        /// <summary>
        /// Maak een nieuw account aan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateParticipantCreateParticipant_Click(object sender, EventArgs e)
        {
            person = new Person(tbCreateParticipantName.Text, dtpCreateParticipantDateOfBirth.Value,tbCreateParticipantStreet.Text,  tbCreateParticipantZipCode.Text, tbCreateParticipantCity.Text, tbCreateParticipantPhoneNumber.Text, tbCreateParticipantEmail.Text, tbCreateParticipantPassword.Text, tbCreateParticipantRekeningnummer.Text);
            if (login.CreateUser(person))
            {
                //btnDeleteParticipant.Enabled = true;
                //btnEditParticipant.Enabled = true;
                //btnParticipants.Enabled = true;

                if(login.LogInUser(person.Email, person.Password))
                {
                    homeform = new HomeForm();
                    this.Close();
                    homeform.Show();
                }
            }
            else
            {
                MessageBox.Show("Er is wat fout gegaan met uw account aanmaken.");
            }
        }
    }
}
