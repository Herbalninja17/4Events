using System;
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

        public int ReservationID
        {
            get { return reservationID; }
            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException("reservationID");}
                reservationID = value;
            }
        }

        public bool EventIsPlayed { get; set; }

        public List<Person> Persons { get; set; }

        public List<Material> Materials { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reservationID">The ID of the reservation</param>
        /// <param name="eventIsPlayed">If the event is playing or not</param>
        public Reservation(int reservationID, bool eventIsPlayed)
        {
            ReservationID = reservationID;
            EventIsPlayed = eventIsPlayed;
        }

        public decimal CalculatePrice()
        {
            if (Materials != null)
            {
                decimal price = 0;

                foreach (Material m in Materials)
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
            if (Materials != null)
            {
                decimal price = 0;

                foreach (Material m in Materials)
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
            foreach (Person p in Persons)
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
            foreach (Person p in Persons)
            {
                if (p == person)
                {
                    Persons.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return ReservationID
                   + " | " + EventIsPlayed
                   + " | " + Persons.Count
                   + " | " + Materials;
        }
    }
}
