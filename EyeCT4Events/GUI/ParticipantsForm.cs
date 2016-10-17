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
    public partial class ParticipantsForm : Form
    {
        public ParticipantsForm()
        {
            InitializeComponent();
        }

        private void btnCreateParticipant_Click(object sender, EventArgs e)
        {
            CreateParticipantForm cpf = new CreateParticipantForm();
            this.Hide();
            cpf.Show();
        }

        private void btnEditParticipant_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            MakeReservationForm mrf = new MakeReservationForm();
            this.Hide();
            mrf.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            HiredMaterialForm hmf = new HiredMaterialForm();
            this.Hide();
            hmf.Show();
        }
    }
}
