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
    public partial class MyReservationsForm : Form
    {
        private HomeForm homeForm;
        private MakeReservationForm makeReservationForm;
        private MyReservationsForm myForm;

        public MyReservationsForm()
        {
            InitializeComponent();
            myForm = this;
        }

        public MyReservationsForm(HomeForm homeForm)
        {
            InitializeComponent();
            myForm = this;
            this.homeForm = homeForm;
        }

        public MyReservationsForm(MakeReservationForm makeReservationForm)
        {
            InitializeComponent();
            myForm = this;
            this.makeReservationForm = makeReservationForm;
        }

        private void MyReservationsForm_Load(object sender, EventArgs e)
        {
            DataReservation.GetReservation();
            foreach (string i in DataReservation.rlist)
            {
                lbMyReservationsEvents.Items.Add(i);
            }
        }

        private void btnPayReservation_Click(object sender, EventArgs e)
        {
            BetaalForm bf = new BetaalForm(this);
            bf.Show();
            this.Hide();
        }

        private void MyReservationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(makeReservationForm != null)
            {
                makeReservationForm.Show();
            }
            else
            {
                HomeForm.homeForm.Show();
            }
        }
    }
}
