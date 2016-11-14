using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.Business.Classes;
using EyeCT4Events.Data.DataClasses;
using System.Data.Sql;

namespace EyeCT4Events.GUI
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        RfidCheck InUit = new RfidCheck();
        RfidForm RFID = new RfidForm();
        Login login = new Login();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
                {
                    string tag = RFID.tagstring;
                    if(InUit.CheckBlock(tag) == true)
                    {
                        if (InUit.CheckUp(tag) == true)
                        {
                            string eventids = Convert.ToString(comboBox1.SelectedItem);
                            string eventid = eventids.Split(')')[0];
                            if (InUit.CheckRsvp(eventid, "", tag) == true)
                            {
                                InUit.CheckIn(tag, 4);
                                MessageBox.Show("Welcome: " + tag.ToString());
                                
                            }
                            else
                            {
                                MessageBox.Show("Sorry, you have no reservation for this event");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please register: " + tag.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, your account has been blocked");
                    }

                                       
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
                {

                    InUit.CheckOut(RFID.tagstring.ToString(), 4);                    
                    MessageBox.Show("Goodbye: " + RFID.tagstring.ToString());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.LogInUser(textBox1.Text, textBox2.Text) == true)
            {
                if (RFID.ShowDialog() == DialogResult.OK) //wait for OK 
                {
                    InUit.CheckInFisrtTime(RFID.tagstring, textBox1.Text);
                    MessageBox.Show("Seccessfully Registered, you can now check in ");
                }                
                groupBox2.Visible = false;

                //LoginForm login = new LoginForm();
                //this.Hide();
                //login.Show();
            }
            else if (login.LogInUser(textBox1.Text, textBox2.Text) == false)
            {
                MessageBox.Show("Email or Password is incorrect.");
            }
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            DataEvent.GetEvent();

            foreach (string i in DataEvent.events)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void CheckIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm.homeForm.Show();
            
        }
    }
}
