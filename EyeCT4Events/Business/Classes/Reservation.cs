using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Reservation
    {
        public static int Map = 0;
        public static int typeid;
        public static int Capacity = 0;
        /// <summary>
        /// Taken from the database (Auto increment).
        /// </summary>
        public int ReservationID { get; private set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool EventIsRunning { get; set; }

        public List<Person> Persons { get; set; }

        public List<Material> Materials { get; set; }

        public CampingSpot CampingSpot { get; set; }

        public decimal Price { get { return CalculateTotalPrice(); } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reservationID">The ID of the reservation</param>
        /// <param name="eventIsRunning">If the event is in progress or not</param>
        /// <param name="campingSpot">Campingspot for the reservation.</param>
        public Reservation(int reservationID, bool eventIsRunning, CampingSpot campingSpot)
        {
            ReservationID = reservationID;
            EventIsRunning = eventIsRunning;
            CampingSpot = campingSpot;

            Persons = new List<Person>();
            Materials = new List<Material>();
        }

        /// <summary>
        /// Constructor
        /// For calculating the price for the reservation.
        /// </summary>
        /// <param name="reservationID">The ID of the reservation</param>
        /// <param name="campingSpot">Campingspot for the reservation.</param>
        public Reservation(int reservationID, CampingSpot campingSpot)
        {
            ReservationID = reservationID;
            CampingSpot = campingSpot;

            Persons = new List<Person>();
            Materials = new List<Material>();
        }

        public Reservation(DateTime begindate, DateTime enddate)
        {
            BeginDate = begindate;
            EndDate = enddate;

            Persons = new List<Person>();
            Materials = new List<Material>();
        }

        /// <summary>
        /// Price for the reservation.
        /// </summary>
        /// <returns></returns>
        private decimal CalculateTotalPrice()
        {
            decimal price = 0;
            if (CampingSpot != null)
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
            if (Persons.Count == 0)
            {
                Persons = new List<Person>();
                Persons.Add(person);
                return true;
            }
            else if (Persons.Count < Capacity)
            {
                foreach (Person p in Persons)
                {
                    if (p.Email == person.Email)
                    {
                        return false;
                    }
                }
                Persons.Add(person);
                return true;
            }
            return false;
        }

        public bool RemovePerson(Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == person.Email)
                {
                    Persons.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string eventIsRunning = "";
            if(EventIsRunning)
            {
                eventIsRunning = "Evenement loopt | ";
            }
            else if(DateTime.Today < BeginDate)
            {
                eventIsRunning = "Evenement start op " + BeginDate.ToString("d/M/yyyy") + " | ";
            }
            else if(BeginDate == default(DateTime) && !EventIsRunning)
            {
                eventIsRunning = "";
            }
            else
            {
                eventIsRunning = "Evenement is voorbij | ";
            }

            string materials = "";
            if(Materials.Count > 0)
            {
                int lastIndex = Materials.Count();
                materials = "Gehuurde materialen: ";

                for(int i = 0; i < lastIndex; i++)
                {
                    if(i == lastIndex - 1)
                    {
                        materials += Materials[i].Name;
                    }
                    else
                    {
                        materials += Materials[i].Name + ", ";
                    }
                }
            }
            else
            {
                materials = "Geen materialen gehuurd";
            }
            

            return "Reserverings ID: " + ReservationID
                   + " | " + eventIsRunning
                   + "Personen: " + Persons.Count // '|' is given with the eventIsRunning string.
                   + " | " + materials;
        }
    }
}
