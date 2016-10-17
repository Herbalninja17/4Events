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
    public partial class LeaseForm : Form
    {
        public LeaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Om materialen te zoeken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeaseSearch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Om naar de form te gaan om je gehuurde materialen te zien.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHired_Click(object sender, EventArgs e)
        {
            HiredMaterialForm hmf = new HiredMaterialForm();
            this.Hide();
            hmf.Show();
        }
        /// <summary>
        /// Om een materiaal te lenen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeaseLease_Click(object sender, EventArgs e)
        {

        }
    }
}
