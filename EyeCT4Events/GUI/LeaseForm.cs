using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.Data.DataClasses;
using EyeCT4Events.GUI;

namespace EyeCT4Events
{
    public partial class LeaseForm : Form
    {
        private LeaseForm leaseForm;
        private HomeForm homeForm;

        private List<Material> products;

        public LeaseForm()
        {
            InitializeComponent();
            leaseForm = this;
        }
        public LeaseForm(HomeForm homeForm)
        {
            InitializeComponent();
            leaseForm = this;
            this.homeForm = homeForm;
            products = DataMaterial.AvailableMaterialList();
            foreach (Material product in products)
            {
                lbLeaseMaterial.Items.Add(product.ToString());
            }
        }

        /// <summary>
        /// Om materialen te zoeken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeaseSearch_Click(object sender, EventArgs e)
        {
            lbLeaseMaterial.Items.Clear();
            List<int> IDs = new List<int>();

            foreach (Material mat in products)
            {
                foreach (int id in IDs)
                {
                    if (mat.ID == id)
                    {
                        lbLeaseMaterial.Items.Add(mat.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Om naar de form te gaan om je gehuurde materialen te zien.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHired_Click(object sender, EventArgs e)
        {
            HiredMaterialForm hmf = new HiredMaterialForm();
            this.Close();
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

        private void LeaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Show();
        }
    }
}
