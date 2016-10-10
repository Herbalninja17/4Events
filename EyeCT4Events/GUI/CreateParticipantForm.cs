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

        private void btnCreateParticipant_Click(object sender, EventArgs e)
        {

        }

        private void btnEditParticipant_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {

        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateParticipantCreateParticipant_Click(object sender, EventArgs e)
        {
            person = new Person(tbCreateParticipantName.Text, dtpCreateParticipantDateOfBirth.Value, tbCreateParticipantCity.Text + " " + tbCreateParticipantZipCode.Text,tbCreateParticipantPhoneNumber.Text, tbCreateParticipantUsername.Text, tbCreateParticipantEmail.Text);
            login.CreateUser(person);
        }
    }
}
