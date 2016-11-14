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
    public partial class HiredMaterialForm : Form
    {
        private bool goParticipantForm = false;
        private bool goLeaseForm = false;

        public HiredMaterialForm()
        {
            InitializeComponent();
            List<Material> materiallist = Material.GetMaterialList(Login.loggedinUser);
            foreach(Material m in materiallist)
            {
                lbMaterial.Items.Add("Naam: "+m.Name +"\t Beschrijving: " + m.Description + "\t Prijs: " + m.Price + "\t Datum geleend: " + m.LeaseDateStart.ToShortDateString() + "\t Datum terug: " + m.LeaseDateEnd.ToShortDateString());
            }
        }
        
        /// <summary>
        /// Om naar de form te gaan om een materiaal te huren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLease_Click(object sender, EventArgs e)
        {
            goLeaseForm = true;
            LeaseForm lf = new LeaseForm();
            this.Close();
            lf.Show();
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

        private void HiredMaterialForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!goParticipantForm && !goLeaseForm)
            {
                HomeForm.homeForm.Show();
            }          
        }

        private void lbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
