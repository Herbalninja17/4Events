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

namespace EyeCT4Events
{
    public partial class MyReservationsForm : Form
    {
        private HomeForm homeForm;
        private MakeReservationForm makeReservationForm;

        public MyReservationsForm()
        {
            InitializeComponent();
        }
        public MyReservationsForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        public MyReservationsForm(MakeReservationForm makeReservationForm)
        {
            InitializeComponent();
            this.makeReservationForm = makeReservationForm;
        }

        private void MyReservationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (homeForm != null && makeReservationForm == null)
            {
                homeForm.Show();
            }
            else if(homeForm == null && makeReservationForm != null)
            {
                makeReservationForm.Show();
            }
        }

        private void MyReservationsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
