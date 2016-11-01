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
            DateTime today = new DateTime(2012,3,4);
            string s = today.ToShortDateString();
            listBox1.Items.Add(s);
        }
    }
}
