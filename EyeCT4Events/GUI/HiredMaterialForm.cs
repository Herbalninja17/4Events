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

        private void btnHired_Click(object sender, EventArgs e)
        {

        }

        private void btnLease_Click(object sender, EventArgs e)
        {

        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm pf = new ParticipantsForm();
            this.Hide();
            pf.Show();
        }
    }
}
