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
    public partial class EditParticipantForm : Form
    {
        public static EditParticipantForm editForm;
        private HomeForm homeForm;
        private bool goParticipantForm = false;
        public static Person adminPerson { get; private set; }
        
        public EditParticipantForm()
        {
            InitializeComponent();
            editForm = this;

            if (Login.loggedinUser.Admin == 0)
            {
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
                btnCreateParticipant.Enabled = false;
                btnCreateParticipant.Visible = false;
                btnLoadParticipant.Enabled = false;
                btnLoadParticipant.Visible = false;
                lbEditParticipantAdminScreen.Enabled = false;
                lbEditParticipantAdminScreen.Visible = false;
            }
            else
            {
                lbEditParticipantAdminScreen.Enabled = true;
                lbEditParticipantAdminScreen.Visible = true;
                btnCreateParticipant.Enabled = true;
                btnCreateParticipant.Visible = true;
                btnLoadParticipant.Enabled = true;
                btnLoadParticipant.Visible = true;
                List<Person> personlist = Data.DataClasses.DataPerson.GetAllPerson();
                foreach(Person p in personlist)
                {
                    lbEditParticipantAdminScreen.Items.Add(p.Email);
                }
            }
        }

        public EditParticipantForm(HomeForm homeform)
            : base()
        {
            this.homeForm = homeform;
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
            this.Hide();
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
            if(dialog == DialogResult.Yes && Login.loggedinUser.Admin == 0)
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
            else if(dialog == DialogResult.Yes && Login.loggedinUser.Admin == 1)
            {
                string email = Convert.ToString(lbEditParticipantAdminScreen.SelectedItem);

                if (Data.DataClasses.DataPerson.AdminGetPerson(email) != null)
                {
                    adminPerson = Data.DataClasses.DataPerson.AdminGetPerson(email);
                    Login.DeleteUser(adminPerson);
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
            goParticipantForm = true;
            ParticipantsForm pf = new ParticipantsForm();
            this.Close();
            pf.Show();
        }

        private void btnLoadParticipant_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(lbEditParticipantAdminScreen.SelectedItem);

            if (Data.DataClasses.DataPerson.AdminGetPerson(email) != null)
            {
                adminPerson = Data.DataClasses.DataPerson.AdminGetPerson(email);
                tbEditParticipantName.Text = adminPerson.Name;
                tbEditParticipantEmail.Text = adminPerson.Email;
                tbEditParticipantCity.Text = adminPerson.City;
                tbEditParticipantPassword.Text = adminPerson.Password;
                tbEditParticipantPhoneNumber.Text = adminPerson.Phonenumber;
                tbEditParticipantAccountNumber.Text = adminPerson.AccountNumber;
                tbEditParticipantAdress.Text = adminPerson.Address;
                tbEditParticipantZipCode.Text = adminPerson.ZipCode;
                dtpEditParticipantDateOfBirth.Value = adminPerson.BirthDate;
            }
        }

        private void EditParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!goParticipantForm)
            {
                HomeForm.homeForm.Show();
            }
            
        }
    }
}
