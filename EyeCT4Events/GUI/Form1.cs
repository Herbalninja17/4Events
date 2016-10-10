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

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Data.Datacom.TestMethode(15).ToString());
            login.LogInUser();
        }

        private void btnLoginCreatAccount_Click(object sender, EventArgs e)
        {
            CreateParticipantForm cpf = new CreateParticipantForm();
            this.Hide();
            cpf.Show();
        }
    }
}
