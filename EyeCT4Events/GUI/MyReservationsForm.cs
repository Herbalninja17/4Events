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
        private MyReservationsForm reservationsForm;
        private HomeForm homeForm;

        public MyReservationsForm()
        {
            InitializeComponent();
            reservationsForm = this;
        }
        public MyReservationsForm(HomeForm homeForm)
        {
            InitializeComponent();
            reservationsForm = this;
            this.homeForm = homeForm;
        }
    }
}
