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

        public void CreateUser(Person person)
        {
            
        }

        public bool LogInUser(string username, string password)
        {
            if (//query check of username + password overeenkomen met iemand uit de database)
            {
                loggedinUser = new Person(username, password);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
