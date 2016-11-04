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
    public partial class EditParticipantForm : Form
    {
        
        public EditParticipantForm()
        {
            InitializeComponent();
            //Laat de gegevens zien van de ingelogde gebruiker.
            tbEditParticipantName.Text = Login.loggedinUser.Name;
            tbEditParticipantEmail.Text = Login.loggedinUser.Email;
            tbEditParticipantCity.Text = Login.loggedinUser.City;
            tbEditParticipantPassword.Text = Login.loggedinUser.Password;
            tbEditParticipantPhoneNumber.Text = Login.loggedinUser.Phonenumber;
            tbEditParticipantAccountNumber.Text = Login.loggedinUser.AccountNumber;
            tbEditParticipantAdress.Text = Login.loggedinUser.Address;
            tbEditParticipantZipCode.Text = Login.loggedinUser.ZipCode;
            dtpEditParticipantDateOfBirth.Value = Login.loggedinUser.BirthDate;
        }

        /// <summary>
        /// Om je accountgegevens te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditParticipantEditParticipant_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Weet u zeker dat u deze wijzigingen wilt doorvoeren?", "Wijziging", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                DateTime dt = dtpEditParticipantDateOfBirth.Value;
                string date = dt.ToShortDateString();
                Login.EditUser(tbEditParticipantName.Text, tbEditParticipantEmail.Text, tbEditParticipantPassword.Text, tbEditParticipantAccountNumber.Text, tbEditParticipantCity.Text, tbEditParticipantZipCode.Text,tbEditParticipantAdress.Text, tbEditParticipantPhoneNumber.Text, date);
            }
        }

        /// <summary>
        /// Om naar de form te gaan om een account te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateParticipant_Click(object sender, EventArgs e)
        {
            CreateParticipantForm cpf = new CreateParticipantForm();
            this.Close();
            cpf.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om je account te verwijderen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Weet u zeker dat u uw account wilt verwijderen? U kunt dit niet meer ongedaan maken.", "Account verwijderen", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                if (Login.DeleteUser(Login.loggedinUser))
                {
                    MessageBox.Show("Account verwijderen is gelukt!");
                    LoginForm lf = new LoginForm();
                    this.Close();
                    lf.Show();
                }
                else
                {
                    MessageBox.Show("Account verwijderen is mislukt!");
                }
            }
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
