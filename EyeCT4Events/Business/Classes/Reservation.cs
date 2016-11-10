using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Reservation
    {
        //Fields
        public static int Map = 0;
        public static int typeid;
        public static int Capacity = 0;

        //Properties

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

        /// <summary>
        /// Gives the price for the reservation by using the CalculateTotalPrice method.
        /// </summary>
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
            Capacity = campingSpot.Capacity;

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
            Capacity = campingSpot.Capacity;

            Persons = new List<Person>();
            Materials = new List<Material>();
        }

        /// <summary>
        /// Constructor
        /// Used in the MakeReservationForm to set a start and end date for the reservation.
        /// </summary>
        /// <param name="begindate">Start date for the reservation/event.</param>
        /// <param name="enddate">End date for the reservation/event.</param>
        public Reservation(DateTime begindate, DateTime enddate)
        {
            BeginDate = begindate;
            EndDate = enddate;

            Persons = new List<Person>();
            Materials = new List<Material>();
        }

        //Methods

        /// <summary>
        /// Price for the reservation.
        /// </summary>
        /// <returns>Price of the campingspot and all hired materials.</returns>
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

        /// <summary>
        /// Seek al materials within the reservation that are not payed yet.
        /// </summary>
        /// <returns>List of materials that are not payed for yet.</returns>
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

        /// <summary>
        /// To find the price of all unpayed materials
        /// </summary>
        /// <returns>Total price of all materials that are not payed for yet.</returns>
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

        /// <summary>
        /// To add a person to the reservation.
        /// </summary>
        /// <param name="person">Person to be added to the reservation.</param>
        /// <returns>true: Person is added to the reservation | false: person already exists 
        /// or the maximum number of persons for the reservation is reached, person is not added</returns>
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

        /// <summary>
        /// To remove a person from the reservation.
        /// </summary>
        /// <param name="person">Person to be removed from the reservation.</param>
        /// <returns>true: Person is removed from the reservation | false: Person does not exist in the reservation.</returns>
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
