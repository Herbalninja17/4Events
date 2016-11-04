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

namespace EyeCT4Events.GUI
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        RfidForm RFID = new RfidForm();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
            {
                MessageBox.Show("Welcome: " + RFID.tagstring.ToString());
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
            {
                MessageBox.Show("Welcome: " + RFID.tagstring.ToString());
            }
        }
    }
}
