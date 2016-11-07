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
        /// <summary>
        /// Alleen een admin kan deze methode gebruiken om een account op te vragen.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Person AdminGetPerson(string email)
        {
            Person p = null ;
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM account WHERE email = '" + email + "'";
                cmd.Connection = Datacom.connect;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string date = Convert.ToString(reader["geboortedatum"]);
                    DateTime d;
                    d = DateTime.Parse(date);
                    p = new Person(Convert.ToString(reader["naam"]), d, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]),Convert.ToString(reader["email"]),Convert.ToString(reader["wachtwoord"]), Convert.ToString(reader["rekeningnummer"]));
                    
                }
                return p;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        /// <summary>
        /// De ingelogde gebruiker ophalen.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
                    if (email == Email && password == Password && admin != 1 && Convert.ToString(reader["bruikbaar"]) != "uitgeschakeld")
                    {
                        string date = Convert.ToString(reader["geboortedatum"]);
                        DateTime d;
                        d = DateTime.Parse(date);
                        Login.loggedinUser = new Person(Convert.ToString(reader["naam"]), d, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Email, Password, Convert.ToString(reader["rekeningnummer"]));
                        Login.loginbool = true;
                        return Login.loggedinUser;
                    }
                    else if (email == Email && password == Password && admin == 1 && Convert.ToString(reader["bruikbaar"]) != "uitgeschakeld")
                    {
                        string date = Convert.ToString(reader["geboortedatum"]);
                        DateTime d;
                        d = DateTime.Parse(date);
                        Login.loggedinUser = new Person(Convert.ToString(reader["naam"]), d, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Email,Password, admin, Convert.ToString(reader["rekeningnummer"]));
                        Login.loginbool = true;
                        return Login.loggedinUser;
                    }
                    else if(email == Email && password == Password && Convert.ToString(reader["bruikbaar"]) == "uitgeschakeld")
                    {
                        Login.loginbool = false;
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
        /// <summary>
        /// Een nieuw account toevoegen aan de database.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Om de admin een persoon te laten wijzigen.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static bool AdminUpdatePerson(Person person)
        {
            try
            {
                string geboortedatum = person.BirthDate.ToShortDateString();

                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "UPDATE account SET naam = '" + person.Name + "', email = '" + person.Email + "', wachtwoord = '" + person.Password + "',rekeningnummer = '" + person.AccountNumber + "', telefoon = '" + person.Phonenumber + "', postcode = '" + person.ZipCode + "', woonplaats = '" + person.City + "', adres = '" + person.Address + "', geboortedatum = '" + geboortedatum + "' WHERE email = '" + EditParticipantForm.adminPerson.Email + "' AND wachtwoord = '" + EditParticipantForm.adminPerson.Password + "';";
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
        /// <summary>
        /// De ingelogde gebruiker wijzigen.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Een account verwijderen.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Mensen die niet aanwezig zijn ophalen.
        /// </summary>
        /// <returns></returns>
        public static List<Person> GetPersonListNotPresent()
        {
            List<Person> personlist = new List<Person>();
            try
            {
                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("SELECT a.* FROM account a INNER JOIN polsband p on a.accountid = p.accountaccountid where p.aanwezig = 0;", Datacom.connect);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        /// <summary>
        /// Mensen die aanwezig zijn ophalen.
        /// </summary>
        /// <returns></returns>
        public static List<Person> GetPersonListPresent()
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
        /// <summary>
        /// Alle accounts die geen beheerder zijn ophalen.
        /// </summary>
        /// <returns></returns>
        public static List<Person> GetAllPerson()
        {
            List<Person> personlist = new List<Person>();
            try
            {
                Person p;
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "SELECT * FROM account WHERE beheerder = 0";
                SqlDataReader reader =  cmd.ExecuteReader();
                while (reader.Read())
                {
                    string date = Convert.ToString(reader["geboortedatum"]);
                    DateTime dt = DateTime.Parse(date);
                    p = new Person(Convert.ToString(reader["naam"]), dt, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Convert.ToString(reader["email"]), Convert.ToString(reader["wachtwoord"]), Convert.ToString(reader["rekeningnummer"]));
                    personlist.Add(p);
                }
                return personlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        /// <summary>
        /// De betaalstatus ophalen van mensen die aanwezig zijn.
        /// </summary>
        /// <returns></returns>
        public static List<Person> GetPersonPresentPaid()
        {
            List<Person> personlist = GetPersonListPresent();
            List<Person> personpaid = new List<Person>();
            foreach (Person pe in personlist)
            {
                try
                {
                    Datacom.OpenConnection();
                    Datacom.command = new SqlCommand("select distinct r.betaaldstatus from reservering r inner join AccountReservering ar on r.ReserveringID = ar.ReserveringReserveringID inner join account a on ar.AccountAccountID = a.AccountID where a.Email = '" + pe.Email + "';", Datacom.connect);
                    SqlDataReader reader = Datacom.command.ExecuteReader();
                    Person p;
                    if (reader.HasRows == true)
                    {
                        while (reader.Read() && reader.HasRows == true)
                        {
                            if (Convert.ToString(reader["betaaldstatus"]) != null)
                            {
                                p = new Person(pe.Name, pe.Email, Convert.ToString(reader["betaaldstatus"]));
                                personpaid.Add(p);
                            }
                        }
                    }
                    else if (reader.HasRows == false)
                    {
                        p = new Person(pe.Name, pe.Email, "");
                        personpaid.Add(p);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Datacom.CloseConnection();
                }
            }
            return personpaid;
        }
        /// <summary>
        /// Om een persoon te zoeken in de MakeReservationForm.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<int> GetSearchedPerson(string name)
        {
            List<int> personlist = new List<int>();
            try
            {
                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("SELECT accountid FROM account WHERE naam like '%" + name + "%'", Datacom.connect);
                SqlDataReader reader = Datacom.command.ExecuteReader();
                while (reader.Read())
                {
                    personlist.Add(Convert.ToInt32(reader["accountid"]));
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
