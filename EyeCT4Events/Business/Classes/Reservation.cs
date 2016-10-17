﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Reservation
    {
        private int reservationID;
        private bool eventIsPlayed;
        private List<Person> persons;
        private List<Material> materials;

        public int ReservationID
        {
            get { return reservationID; }
            set
            {
                if (value == null) { throw new ArgumentOutOfRangeException("reservationID");}
                reservationID = value;
            }
        }

        public bool EventIsPlayed
        {
            get { return eventIsPlayed; }
            set { eventIsPlayed = value; }
        }

        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public List<Material> Materials
        {
            get { return materials; }
            set { materials = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reservationID">The ID of the reservation</param>
        /// <param name="eventIsPlayed">If the event is playing or not</param>
        public Reservation(int reservationID, bool eventIsPlayed)
        {
            ReservationID = reservationID;
            EventIsPlayed = eventIsPlayed;
            Persons = new List<Person>();
            Materials = new List<Material>();
        }

        public decimal CalculatePrice()
        {
            if (materials != null)
            {
                decimal price = 0;

                foreach (Material m in materials)
                {
                    if (!m.IsPayed)
                    {
                        price += m.Price;
                    }
                }

                return price;
            }

            return 0;

        }

        public List<Material> OpenMaterialPayment()
        {
            return null;
        }

        public decimal CalculateMaterialPayment()
        {
            if (materials != null)
            {
                decimal price = 0;

                foreach (Material m in materials)
                {
                    if (!m.IsPayed)
                    {
                        price += m.Price;
                    }
                }

                return price;
            }

            return 0;
        }

        public bool AddPerson(Person person)
        {
            foreach (Person p in persons)
            {
                if (p == person)
                {
                    return false;
                }
            }

            Persons.Add(person);
            return true;
        }

        public bool RemovePerson(Person person)
        {
            foreach (Person p in persons)
            {
                if (p == person)
                {
                    persons.Remove(p);
                    return true;
                }
            }
            return false;
        }
    }
}
