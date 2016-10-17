using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Person
    {
        //Persoonklasse
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Reservation> Reservations { get; set; }

        /// <summary>
        /// Om een nieuw persoon aan te maken
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        /// <param name="address"></param>
        /// <param name="phonenumber"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Person(string name, DateTime birthDate, string address, string phonenumber, string username, string email,string password)
        {
            Name = name;
            BirthDate = birthDate;
            Address = address;
            Phonenumber = phonenumber;
            Username = username;
            Email = email;
            Password = password;
        }

        /// <summary>
        /// Om een persoon in te loggen
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public Person(string username,string password)
        {
            Username = username;
            Password = password;
        }
    }
}
