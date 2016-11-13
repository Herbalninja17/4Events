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
using EyeCT4Events.Business.Classes;

namespace EyeCT4Events
{
    public partial class BetaalForm : Form
    {
        private MyReservationsForm reservationsForm;
        RfidForm RFID = new RfidForm();
        RfidCheck InUit = new RfidCheck();

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
            if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
            {
                InUit.rfidbetaal();
                MessageBox.Show("U heb betaald");
            }
        }

        private void BetaalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reservationsForm.Show();
        }
    }
}
