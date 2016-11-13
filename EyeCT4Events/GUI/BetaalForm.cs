using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.GUI;
using EyeCT4Events.Data.DataClasses;

namespace EyeCT4Events
{
    public partial class BetaalForm : Form
    {
        private MyReservationsForm reservationsForm;

        public List<string> betaaldlist;
        public BetaalForm(MyReservationsForm reservationsForm)
        {
            InitializeComponent();
            this.reservationsForm = reservationsForm;
        }

        private void BetaalForm_Load(object sender, EventArgs e)
        {
            betaaldlist = DataReservation.GetReservationsLoggedInPerson(Login.loggedinUser);
            foreach(string s in betaaldlist)
            {
                lbPaid.Items.Add(s);
            }
        }

        private void btnPayReservation_Click(object sender, EventArgs e)
        {

        }

        private void BetaalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reservationsForm.Show();
        }
    }
}
