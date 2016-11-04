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
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Kies de geselecteerde locatie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMapChooseLocation_Click(object sender, EventArgs e)
        {
            Reservation.Map = Convert.ToInt32(comboBox2.Text);
            this.Close();
        }
    }
}
