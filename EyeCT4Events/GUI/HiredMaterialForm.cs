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
        public HiredMaterialForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Om naar de form te gaan om een materiaal te huren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLease_Click(object sender, EventArgs e)
        {
            LeaseForm lf = new LeaseForm();
            this.Hide();
            lf.Show();
        }

        /// <summary>
        /// Om naar de algemene participants form te gaan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm pf = new ParticipantsForm();
            this.Hide();
            pf.Show();
        }
    }
}
