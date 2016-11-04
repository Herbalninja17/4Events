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
        public static Person loggedinUser;
        private string email;
        private string password;

        public Login()
        {
            
        }
        /// <summary>
        /// Maak een nieuw account aan.
        /// </summary>
        /// <param name="person"></param>
        public bool CreateUser(Person person)
        {
            //Zorgt ervoor dat er alleen een dag,maand en jaar wordt meegegeven.
            string datetime = person.BirthDate.ToShortDateString();

            int latestid = Datacom.GetLatestID("account") + 1;

            if (latestid == 0)
            {
                Console.WriteLine("Iets is fout met ophalen van ID.");
                return false;
            }
            else
            {
                try
                {
                    Datacom.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Datacom.connect;
                    cmd.CommandText = "INSERT INTO account(accountid,email,wachtwoord,naam,telefoon,adres,postcode,rekeningnummer,geboortedatum) VALUES (" + latestid + ", '" + person.Email + "', '" + person.Password + "', '" + person.Name + "', '" + person.Phonenumber + "', '" + person.Address + "', '" + person.AccountNumber + "', '" + datetime + "');";

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
                finally
                {
                    Datacom.CloseConnection();
                }
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
            //Query check of username + password overeenkomen met iemand uit de database
            Datacom.OpenConnection();
            //Haal email en wachtwoord op.
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM account WHERE email like '" + email + "'AND wachtwoord like '" + password + "';";
            cmd.Connection = Datacom.connect;
            cmd.ExecuteScalar();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                this.email = Convert.ToString(reader["email"]);
                this.password = Convert.ToString(reader["wachtwoord"]);
                if (email == this.email && password == this.password)
                {
                    string date = Convert.ToString(reader["geboortedatum"]);
                    DateTime d;
                    d = DateTime.Parse(date);
                    loggedinUser = new Person(this.email, this.password);
                    loggedinUser.Name = Convert.ToString(reader["naam"]);
                    loggedinUser.AccountNumber = Convert.ToString(reader["rekeningnummer"]);
                    loggedinUser.Address = Convert.ToString(reader["adres"]);
                    loggedinUser.BirthDate = d;
                    loggedinUser.Phonenumber = Convert.ToString(reader["telefoon"]);
                    return true;
                }
               
            }
            Datacom.CloseConnection();


            return false;
        }
        /// <summary>
        /// Methode om gebruiker te wijzigen.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="accountnumber"></param>
        /// <param name="adress"></param>
        /// <param name="zipcode"></param>
        /// <param name="phonenumber"></param>
        /// <param name="birthdate"></param>
        /// <returns></returns>
        public static bool EditUser(string name,string email,string password,string accountnumber,string adress,string zipcode, string phonenumber,string birthdate)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "UPDATE account SET naam = '" + name + "', email = '" + email + "', wachtwoord = '" + password + "',rekeningnummer = '" + accountnumber + "', telefoon = '" + phonenumber + "', postcode = '" + zipcode + "', adres = '" + adress + "', geboortedatum = '" + birthdate + "' WHERE email = '" + Login.loggedinUser.Email + "' AND wachtwoord = '" + Login.loggedinUser.Password + "';";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                Datacom.CloseConnection();
                DateTime dt = DateTime.Parse(birthdate);

                loggedinUser.Name = name;
                loggedinUser.Email = email;
                loggedinUser.Password = password;
                loggedinUser.AccountNumber = accountnumber;
                loggedinUser.Address = adress;
                loggedinUser.Phonenumber = phonenumber;
                loggedinUser.BirthDate = dt;
            }
        }
    }
}
