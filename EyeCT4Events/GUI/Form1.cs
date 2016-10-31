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
    public partial class LoginForm : Form
    {
        Login login = new Login();
        RfidForm RFID = new RfidForm();

        public LoginForm()
        {
            
            InitializeComponent();            
        }
        
        /// <summary>
        /// Inloggen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginLogin_Click(object sender, EventArgs e)
        {

            if (login.LogInUser(tbLoginEmail.Text, tbLoginWachtwoord.Text) == true)
            {
                //Rechard zijn super sexy werkend code!
                //if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
                //{
                //    MessageBox.Show("Success Bitches, your tag is: " + RFID.tagstring.ToString());
                //}
                //^Rechard zijn super sexy werkend code!^

                ParticipantsForm pf = new ParticipantsForm();
                this.Hide();
                pf.Show();
            }
            else if(login.LogInUser(tbLoginEmail.Text,tbLoginWachtwoord.Text) == false)
            {
                MessageBox.Show("Email or Password is incorrect.");
            }
            
        }

        /// <summary>
        /// Laat de form zien om een nieuw account aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginCreatAccount_Click(object sender, EventArgs e)
        {
            CreateParticipantForm cpf = new CreateParticipantForm();
            this.Hide();
            cpf.Show();
        }
    }
}


