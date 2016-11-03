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
        public ParticipantsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Om naar de form te gaan om een nieuw account aan te maken.
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
        /// Om naar de form te gaan om een reservering te plaatsen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvents_Click(object sender, EventArgs e)
        {
            MakeReservationForm mrf = new MakeReservationForm();
            this.Close();
            mrf.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om materiaal te huren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaterial_Click(object sender, EventArgs e)
        {
            HiredMaterialForm hmf = new HiredMaterialForm();
            this.Close();
            hmf.Show();
        }
    }
}
