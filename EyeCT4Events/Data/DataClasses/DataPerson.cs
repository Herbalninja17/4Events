using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EyeCT4Events.Data.DataClasses
{
    class DataPerson
    {
        private static string Email;
        private static string Password;

        public DataPerson()
        {
            
        }

        public static Person GetPerson(string email, string password)
        {
            try
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
                    Person.AcID = Convert.ToInt32(reader["AccountID"]);
                    Email = Convert.ToString(reader["email"]);
                    Password = Convert.ToString(reader["wachtwoord"]);
                    int admin = Convert.ToInt32(reader["beheerder"]);
                    if (email == Email && password == Password && admin != 1)
                    {
                        string date = Convert.ToString(reader["geboortedatum"]);
                        DateTime d;
                        d = DateTime.Parse(date);
                        Login.loggedinUser = new Person(Convert.ToString(reader["naam"]), d, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Email, Password, Convert.ToString(reader["rekeningnummer"]));
                        Login.loginbool = true;
                        return Login.loggedinUser;
                    }
                    else if (email == Email && password == Password && admin == 1)
                    {
                        string date = Convert.ToString(reader["geboortedatum"]);
                        DateTime d;
                        d = DateTime.Parse(date);
                        Login.loggedinUser = new Person(Convert.ToString(reader["naam"]), d, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Email,Password, admin, Convert.ToString(reader["rekeningnummer"]));
                        Login.loginbool = true;
                        return Login.loggedinUser;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Login.loginbool = false;
                return Login.loggedinUser;
            }
            finally
            {
                Datacom.CloseConnection();
            }
            return Login.loggedinUser;
        }

        public static void SetPerson(Person person)
        {
            
        }

        public static bool UpdatePerson(Person person)
        {
            try
            {
                string geboortedatum = person.BirthDate.ToShortDateString();

                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "UPDATE account SET naam = '" + person.Name + "', email = '" + person.Email + "', wachtwoord = '" + person.Password + "',rekeningnummer = '" + person.AccountNumber + "', telefoon = '" + person.Phonenumber + "', postcode = '" + person.ZipCode + "', woonplaats = '" + person.City + "', adres = '" + person.Address + "', geboortedatum = '" + geboortedatum + "' WHERE email = '" + Login.loggedinUser.Email + "' AND wachtwoord = '" + Login.loggedinUser.Password + "';";
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

                Login.loggedinUser.Name = person.Name;
                Login.loggedinUser.Email = person.Email;
                Login.loggedinUser.Password = person.Password;
                Login.loggedinUser.AccountNumber = person.AccountNumber;
                Login.loggedinUser.Address = person.Address;
                Login.loggedinUser.City = person.City;
                Login.loggedinUser.ZipCode = person.ZipCode;
                Login.loggedinUser.Phonenumber = person.Phonenumber;
                Login.loggedinUser.BirthDate = person.BirthDate;
            }
        }

        public static List<Person> GetPersonList()
        {
            return null;
        }
    }
}
