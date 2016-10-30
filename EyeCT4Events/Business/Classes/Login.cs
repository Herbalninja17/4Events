using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Login
    {
        public Person loggedinUser;

        public Login()
        {
            
        }
        /// <summary>
        /// Maak een nieuw account aan.
        /// </summary>
        /// <param name="person"></param>
        public void CreateUser(Person person)
        {
            
        }
        /// <summary>
        /// Log een account in.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LogInUser(string username, string password)
        {
            //query check of username + password overeenkomen met iemand uit de database
            if ("" == "")
            {
                loggedinUser = new Person(username, password);
                return true;
            }
                return false;
        }
    }
}
