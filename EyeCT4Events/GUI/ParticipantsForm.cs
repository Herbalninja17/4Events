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
        private List<Person> personpresentlist;
        private List<Person> personnotpresentlist;
        private List<Person> personpresentpaidlist;

        public ParticipantsForm()
        {
            InitializeComponent();
            participantsForm = this;
            if(Data.DataClasses.DataPerson.GetPersonListPresent() != null)
            {
                personpresentlist = Data.DataClasses.DataPerson.GetPersonListPresent();
                foreach(Person p in personpresentlist)
                {
                    lbParticipantsPresent.Items.Add("Naam: " + p.Name+" Email: " + p.Email );
                }
            }
            else
            {
                MessageBox.Show("iets mis gegaan met persoon ophalen.");
            }
            if(Data.DataClasses.DataPerson.GetPersonListNotPresent() != null)
            {
                personnotpresentlist = Data.DataClasses.DataPerson.GetPersonListNotPresent();
                foreach (Person p in personnotpresentlist)
                {
                    lbParticipantsNotPresent.Items.Add("Naam: "+ p.Name + " Email : " + p.Email);
                }
            }
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
        /// <summary>
        /// Knop om de betaalstatus van de aanwezigen te laten zien.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipantsPaid_Click(object sender, EventArgs e)
        {
            lbParticipantsPresent.Items.Clear();
            if(Data.DataClasses.DataPerson.GetPersonPresentPaid() != null)
            {
                personpresentpaidlist = Data.DataClasses.DataPerson.GetPersonPresentPaid();
                foreach(Person p in personpresentpaidlist)
                {
                    if (p.Payed != null && p.Payed != "")
                    {
                        lbParticipantsPresent.Items.Add("Naam: " + p.Name + " Email: " + p.Email + " Betaald: " + p.Payed);
                    }
                    else if(p.Payed == "")
                    {
                        lbParticipantsPresent.Items.Add("Naam: " + p.Name + " Email: " + p.Email + " Betaald: Niet betaald");
                    }
                }
            }
        }
    }
}
