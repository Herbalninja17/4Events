using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Events.Data;
using System.Data.SqlClient;

namespace EyeCT4Events
{
    public class Login
    {
        public Person loggedinUser;
        private string email;
        private string password;

        public Login()
        {
            
        }
        /// <summary>
        /// Maak een nieuw account aan.
        /// </summary>
        /// <param name="person"></param>
        public void CreateUser(Person person)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "INSERT INTO account(email,wachtwoord,naam,telefoonnummer,adres,postcode,rekeningnummer,geboortedatum) VALUES (" + person.Email + ", " + person.Password + ", " + person.Name + ", " + person.Phonenumber + ", " + person.Address + ", " + person.ZipCode + ", " + person.AccountNumber + ", " + person.BirthDate + ");";

                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        /// <summary>
        /// Check of de ingevulde gegevens overeenkomen met een account.
        /// Log dat account in.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LogInUser(string email, string password)
        {
            //query check of username + password overeenkomen met iemand uit de database
            Datacom.OpenConnection();
            //Haal email op.
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT email FROM account WHERE email like '" + email + "';";
            cmd.Connection = Datacom.connect;
            cmd.ExecuteScalar();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.email = Convert.ToString(reader["username"]);
            }
            //Haal wachtwoord op.
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "SELECT wachtwoord FROM account WHERE wachtwoord like '" + password + "';";
            cmd2.Connection = Datacom.connect;
            cmd2.ExecuteNonQuery();
            SqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                this.password = Convert.ToString(reader["wachtwoord"]);
            }
            Datacom.CloseConnection();
            //if ("" == "")
            //{
            //    return true;
            //}

            if (email == this.email && password == this.password)
            {
                loggedinUser = new Person(this.email, this.password);
                return true;
            }
            return false;
        }
    }
}
