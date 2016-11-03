using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Person
    {
        //Fields
        private string name;
        private DateTime birthDate;
        private string address;
        private string zipcode;
        private string phonenumber;
        private string email;
        private string password;
        private string accountnumber;
        private List<Reservation> reservations;

        //Persoonklasse
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("name");}
                    throw new ArgumentException("name");
                }
                name = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                DateTime today = DateTime.Today;
                if (value >= today) { throw new ArgumentOutOfRangeException("birthDate"); }
                birthDate = value;
            }
        }

        public string Address
        {
            get { return address;}
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("address"); }
                    throw new ArgumentException("address");
                }
                address = value;
            }
        }
        public string ZipCode
        {
            get { return zipcode; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("zipcode"); }
                    throw new ArgumentException("zipcode");
                }
                zipcode = value;
            }
        }

        public string Phonenumber
        {
            get { return phonenumber; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("phonenumber"); }
                    throw new ArgumentException("phonenumber");
                }

                if (!value.StartsWith("0")) { throw new ArgumentException("phonenumber"); }
                phonenumber = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("email"); }
                    throw new ArgumentException("email");
                }
                if (value.IndexOf("@") == -1) { throw new ArgumentException("email"); }
                if (value.IndexOf("@") > 1)
                {
                    int index = value.IndexOf("@");
                    if (value.IndexOf(".", index) == -1) { throw new ArgumentException("email"); }
                }

                email = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("password"); }
                    throw new ArgumentException("password");
                }

                password = value;
            }
        }
        public string AccountNumber
        {
            get { return accountnumber; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("accountnumber"); }
                    throw new ArgumentException("accountnumber");
                }

                accountnumber = value;
            }
        }

        public List<Reservation> Reservations { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the person</param>
        /// <param name="birthDate">The Date of Birth of the person</param>
        /// <param name="address">The address of the person</param>
        /// <param name="phonenumber">The Phonenumber of the person</param>
        /// <param name="email">The Email of the person</param>
        /// <param name="password">The Password of the person</param>
        /// <param name="accountnumber">The Accountnumber of the person</param>
        public Person(string name, DateTime birthDate, string address,string zipcode, string phonenumber, string email,string password,string accountnumber)
        {
            Name = name;
            BirthDate = birthDate;
            Address = address;
            ZipCode = zipcode;
            Phonenumber = phonenumber;
            Email = email;
            Password = password;
            AccountNumber = accountnumber;
            Reservations = new List<Reservation>();
        }

        /// <summary>
        /// Om een persoon in te loggen
        /// </summary>
        /// <param name="email">Username of the person</param>
        /// <param name="password">Password of the person</param>
        public Person(string email,string password)
        {
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
           return Name
                + " | " + birthDate
                + " | " + Address
                + " | " + ZipCode
                + " | " + Phonenumber
                + " | " + Email
                + " | " + Password
                ;
        }
    }
}
