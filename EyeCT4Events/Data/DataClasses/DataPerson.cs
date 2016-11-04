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

        //check of email al in de database voor komt, moet niet true zijn
        public static bool CheckPerson(Person person)
        {
            string email = "";
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "SELECT email FROM account WHERE email = '" + person.Email + "';";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email = Convert.ToString(reader["email"]);
                }
                if(email == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
                return true;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        public static bool SetPerson(Person person)
        {
            //Zorgt ervoor dat er alleen een dag,maand en jaar wordt meegegeven.
            string datetime = person.BirthDate.ToShortDateString();

            if (CheckPerson(person) == false)
                {
                    try
                    {
                        Datacom.OpenConnection();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Datacom.connect;
                        cmd.CommandText = "INSERT INTO account(email,wachtwoord,naam,telefoon,adres,woonplaats,postcode,rekeningnummer,geboortedatum,beheerder) VALUES ('" + person.Email + "', '" + person.Password + "', '" + person.Name + "', '" + person.Phonenumber + "', '" + person.Address + "', '" + person.City + "', '" + person.ZipCode + "', '" + person.AccountNumber + "', '" + datetime + "', " + person.Admin + ");";

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
            else
            {
                return false;
            }
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
        public static bool DeletePerson(Person p)
        {
            try
            {
                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("UPDATE account SET bruikbaar = 'uitgeschakeld' WHERE email = '" + p.Email + "' and wachtwoord = '" + p.Password + "'", Datacom.connect);
                Datacom.command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        public static List<Person> GetPersonList()
        {
            List<Person> personlist = new List<Person>();
            try
            {
                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("SELECT a.* FROM account a INNER JOIN polsband p on a.accountid = p.accountaccountid where p.aanwezig = 1;", Datacom.connect);
                SqlDataReader reader = Datacom.command.ExecuteReader();
                Person p;
                while (reader.Read())
                {
                    string date = Convert.ToString(reader["geboortedatum"]);
                    DateTime dt = DateTime.Parse(date);
                    p = new Person(Convert.ToString(reader["naam"]), dt, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Convert.ToString(reader["email"]), Convert.ToString(reader["wachtwoord"]), Convert.ToString(reader["rekeningnummer"]));
                    personlist.Add(p);
                }
                return personlist;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                Datacom.CloseConnection();
            }
            
        }
    }
}
