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
        //Fields
        public static Person loggedinUser;
        public static bool loginbool;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Login()
        {

        }

        //Methods

        /// <summary>
        /// To create a new account.
        /// </summary>
        /// <param name="person">Person details for the new account.</param>
        /// <returns>true: new account is created | false: person (email) already exists in the database</returns>
        public bool CreateUser(Person person)
        {
            if (Data.DataClasses.DataPerson.SetPerson(person))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// To log in as a specific person.
        /// </summary>
        /// <param name="email">Email (username) for the account.</param>
        /// <param name="password">Password for the account.</param>
        /// <returns>true: User is found in the database, User is logged in | false: User does not exist in the database.</returns>
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
        /// Method to change a users details.
        /// </summary>
        /// <param name="name">Name of the user.</param>
        /// <param name="email">Email of the user.</param>
        /// <param name="password">Password of the user.</param>
        /// <param name="accountnumber">Banking account number.</param>
        /// <param name="city">City the user lives in.</param>
        /// <param name="zipcode">Zipcode for the users address.</param>
        /// <param name="adress">Street and number the user lives at.</param>
        /// <param name="phonenumber">Phonenumber of the user.</param>
        /// <param name="birthdate">Date the user was born.</param>
        public static void EditUser(string name, string email, string password, string accountnumber, string city, string zipcode, string adress, string phonenumber, string birthdate)
        {
            DateTime dt = DateTime.Parse(birthdate);
            Person editperson = new Person(name, dt, adress, zipcode, city, phonenumber, email, password, accountnumber);
            if (Login.loggedinUser.Admin == 0)
            {
                if (Data.DataClasses.DataPerson.UpdatePerson(editperson))
                {
                    MessageBox.Show("Wijziging is gelukt.");
                }
            }
            else if (loggedinUser.Admin == 1)
            {
                if (Data.DataClasses.DataPerson.AdminUpdatePerson(editperson))
                {
                    MessageBox.Show("Wijziging is gelukt.");
                }
            }
        }

        /// <summary>
        /// To 'delete' (set to inactive as is mandatory by law) a user from the database.
        /// </summary>
        /// <param name="p">Person to be deleted.</param>
        /// <returns>true: person is no longer available from the database | false: person does not exist in the database.</returns>
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
