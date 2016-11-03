using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Reservation
    {
        private bool eventIsPlayed;

        /// <summary>
        /// Taken from the database (Auto increment).
        /// </summary>
        public int ReservationID { get; private set; }

        public bool EventIsPlayed { get; set; }

        public List<Person> Persons { get; set; }

        public List<Material> Materials { get; set; }

        public CampingSpot CampingSpot { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reservationID">The ID of the reservation</param>
        /// <param name="eventIsPlayed">If the event is playing or not</param>
        public Reservation(int reservationID, bool eventIsPlayed, CampingSpot campingSpot)
        {
            ReservationID = reservationID;
            EventIsPlayed = eventIsPlayed;
            CampingSpot = campingSpot;
        }

        /// <summary>
        /// Price for the reservation.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTotalPrice()
        {
            decimal price = 0;
            if(CampingSpot != null)
            {
                price += CampingSpot.Price;
            }

            if (Materials != null)
            {
                foreach (Material m in Materials)
                {
                    price += m.Price;
                }
            }
            return price;
        }

        public List<Material> OpenMaterialPayment()
        {
            List<Material> mat = new List<Material>();

            if (Materials != null)
            {
                foreach (Material m in Materials)
                {
                    if (!m.IsPayed)
                    {
                        mat.Add(m);
                    }
                }
                return mat;
            }
            return null;
        }

        public decimal CalculateOpenMaterialPayment()
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
