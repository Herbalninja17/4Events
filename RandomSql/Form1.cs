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
    }
}
