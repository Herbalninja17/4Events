using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Events.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EyeCT4Events
{
    public class Login
    {
        public static Person loggedinUser;
        public static bool loginbool;

        public Login()
        {
            
        }
        /// <summary>
        /// Maak een nieuw account aan.
        /// </summary>
        /// <param name="person"></param>
        public bool CreateUser(Person person)
        {
            if(Data.DataClasses.DataPerson.SetPerson(person))
            {
                return true;
            }
            else
            {
                return false;
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
            loggedinUser = Data.DataClasses.DataPerson.GetPerson(email, password);
            if (loginbool == true)
            {
                loginbool = false;
                return true;
            }
            else
            {
                return false;
            }
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
        public static void EditUser(string name,string email,string password,string accountnumber, string city,string zipcode, string adress, string phonenumber,string birthdate)
        {
            DateTime dt = DateTime.Parse(birthdate);
            Person editperson = new Person(name, dt, adress, zipcode, city, phonenumber, email, password, accountnumber);
            if (Data.DataClasses.DataPerson.UpdatePerson(editperson))
            {
                MessageBox.Show("Wijziging is gelukt.");
            }
        }
        public static bool DeleteUser(Person p)
        {
            if (Data.DataClasses.DataPerson.DeletePerson(p))
            {
                return true;
            }
            else { return false; }
        }
    }
}
