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
        /// Check of die al is gereserveerd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMapChooseLocation_Click(object sender, EventArgs e)
        {
            if (Data.DataClasses.DataCampingSpot.CheckCampingSpot(Convert.ToInt32(comboBox2.Text)))
            {
                MessageBox.Show("Plaats al bezet, kies een andere.");
            }
            else if(Data.DataClasses.DataCampingSpot.CheckCampingSpot(Convert.ToInt32(comboBox2.Text)) == false)
            {
                Reservation.Map = Convert.ToInt32(comboBox2.Text);
                this.Close();
            }
        }
    }
}
