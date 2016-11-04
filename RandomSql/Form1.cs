using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events;
using System.Data.SqlClient;


namespace RandomSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=mssql.fhict.local; Database=dbi338530; User Id=dbi338530; Password= Qwerty123";
        }

        SqlConnection conn = new SqlConnection();
        private SqlCommand command;
        private SqlDataReader reader;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                conn.Open();
                command = new SqlCommand("select * from account where accountid = 1", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(String.Format("ID: {0} \t Email: {1} \t Naam: {2}", reader[0], reader[1], reader[3]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                
                conn.Open();
                command = new SqlCommand("select * from account where wachtwoord = 'datumtest' AND email = 'datum@test.nl'", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string date = Convert.ToString(reader["geboortedatum"]);
                    DateTime d;
                    d = DateTime.Parse(date);
                    listBox1.Items.Add(reader["email"]);
                    listBox1.Items.Add(reader["wachtwoord"]);
                    listBox1.Items.Add(reader["naam"]);
                    listBox1.Items.Add(reader["rekeningnummer"]);    
                    listBox1.Items.Add(reader["adres"]);
                    listBox1.Items.Add(reader["telefoon"]);
                    listBox1.Items.Add(reader["postcode"]);
                    listBox1.Items.Add(d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "j";
                string email = "j@j.j";
                string password = "j";
                string accountnumber = "0000000";
                string phonenumber = "011111111";
                string zipcode = "3333jj";
                string adress = "j";
                string birthdate = "1-2-2016";
                string email2 = "henk@henk.henk";
                string password2 = "henk";
                conn.Open();
                command = new SqlCommand("UPDATE account SET naam = '" + name + "', email = '" + email + "', wachtwoord = '" + password + "',rekeningnummer = '" + accountnumber + "', telefoon = '" + phonenumber + "', postcode = '" + zipcode + "', adres = '" + adress + "', geboortedatum = '" + birthdate + "' WHERE email = '" + email2 + "' AND wachtwoord = '" + password2 + "';", conn);
                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        //beschikbare plaatsen ophalen.
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT p.plaatsid,pt.naam,pt.beschrijving FROM ptype pt inner join plaats p ON pt.typeid = p.typeid WHERE p.status = 'beschikbaar'", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(Convert.ToString(reader["plaatsid"]));
                    listBox1.Items.Add(Convert.ToString(reader["naam"]));
                    listBox1.Items.Add(Convert.ToString(reader["beschrijving"]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        //verhuurde plaatsen ophalen.
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT p.plaatsid,pt.naam,pt.beschrijving FROM ptype pt inner join plaats p ON pt.typeid = p.typeid WHERE p.status NOT LIKE 'beschikbaar'", conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(Convert.ToString(reader["plaatsid"]));
                    listBox1.Items.Add(Convert.ToString(reader["naam"]));
                    listBox1.Items.Add(Convert.ToString(reader["beschrijving"]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        //zet een plaats op verhuurd.
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = new SqlCommand("UPDATE plaats SET status = 'verhuurd' WHERE plaatsid IN (SELECT plaatsid FROM reservering)", conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        //zet een plaats op beschikbaar.
        //fixen !!!!!!!!!!!!             string vandaag = 3-11-2016 maar in database 2016-11-3             fixen !!!!!!!!!
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                string vandaag = today.ToShortDateString();
                conn.Open();
                command = new SqlCommand("UPDATE plaats SET status = 'beschikbaar' WHERE status = 'verhuurd' AND plaatsid = (SELECT r.plaatsid FROM reservering r WHERE r.einddatum = '" + vandaag + "');", conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
