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
    public partial class LoginForm : Form
    {
        Login login = new Login();
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

            if (login.LogInUser(tbLoginUsername.Text, tbLoginPassword.Text) == true)
            {
                ParticipantsForm pf = new ParticipantsForm();
                this.Hide();
                pf.Show();
            }
            else if(login.LogInUser(tbLoginUsername.Text,tbLoginPassword.Text) == false)
            {
                MessageBox.Show("Username or Password incorrect.");
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


