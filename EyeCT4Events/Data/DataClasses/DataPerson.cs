using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EyeCT4Events.Data.DataClasses
{
    public static class DataPerson
    {
        private static string Email;
        private static string Password;

        /// <summary>
        /// Only an admin can use this method to get a person by email.
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>Person</returns>
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
        /// Gets the logged in user.
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Password</param>
        /// <returns>Logged in User</returns>
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

        /// <summary>
        /// Checks of an email already exists in the database.
        /// </summary>
        /// <param name="person">Person</param>
        /// <returns>Bool (False to continue)</returns>
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
        /// Inserts a new account in the database.
        /// </summary>
        /// <param name="person">Person</param>
        /// <returns>bool (true for succes)</returns>
        public static bool SetPerson(Person person)
        {
            //Makes sure that the date format is Day, Month, Year
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
        /// An admin can update a person.
        /// </summary>
        /// <param name="person">Person</param>
        /// <returns>bool (true for succes)</returns>
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
        /// An user can update his profile.
        /// </summary>
        /// <param name="person">Person</param>
        /// <returns>bool (true for succes)</returns>
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
        /// Disables an account.
        /// </summary>
        /// <param name="p">Person</param>
        /// <returns>bool (true for succes)</returns>
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
        /// Gets all people who aren't Present (checked in).
        /// </summary>
        /// <returns>List of People</returns>
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
        /// Gets all peaople who are Present (checked in).
        /// </summary>
        /// <returns>List of People</returns>
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
        /// Gets all accounts who aren't admin.
        /// </summary>
        /// <returns>List of Accounts</returns>
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
                    p = new Person(Convert.ToString(reader["naam"]), Convert.ToDateTime(reader["Geboortedatum"]) , Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Convert.ToString(reader["email"]), Convert.ToString(reader["wachtwoord"]), Convert.ToString(reader["rekeningnummer"]));
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
        /// Gets a list of people who are present and their payment status.
        /// </summary>
        /// <returns>List of People</returns>
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
        /// Searches for a specific person to add in the MakeReservationForm.
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>List of People</returns>
        public static List<Person> GetSearchedPerson(string name)
        {
            List<Person> personlist = new List<Person>();
            try
            {
                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("SELECT email FROM account WHERE naam like '%" + name + "%'", Datacom.connect);
                SqlDataReader reader = Datacom.command.ExecuteReader();
                while (reader.Read())
                {
                    Person p = new Person(Convert.ToString(reader["email"]));
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
        public static Person GetPersonByID(int id)
        {
            Person p = null;
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * from account where accountid = " + id + "", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string date = Convert.ToString(reader["geboortedatum"]);
                    DateTime dt = DateTime.Parse(date);
                    p = new Person(Convert.ToString(reader["naam"]), dt, Convert.ToString(reader["adres"]), Convert.ToString(reader["postcode"]), Convert.ToString(reader["woonplaats"]), Convert.ToString(reader["telefoon"]), Convert.ToString(reader["email"]), Convert.ToString(reader["wachtwoord"]), Convert.ToString(reader["rekeningnummer"]));
                    return p;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return p;
            }
            finally
            {
                Datacom.CloseConnection();
            }
            return p;
        }
    }
}
