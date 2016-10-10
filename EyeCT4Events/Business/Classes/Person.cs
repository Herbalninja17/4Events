using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public Person(string name, DateTime birthDate, string address, string username, string email)
        {
            Name = name;
            BirthDate = birthDate;
            Address = address;
            Username = username;
            Email = email;
        }
    }
}
