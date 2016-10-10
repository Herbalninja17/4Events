using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public bool EventIsPlayed { get; set; }

        public Reservation(int reservationID, bool eventIsPlayed)
        {
            ReservationID = reservationID;
            EventIsPlayed = eventIsPlayed;
        }

        public decimal CalculatePrice()
        {
            return 0;
        }

        public List<Material> OpenMaterialPayment()
        {
            return null;
        }

        public decimal CalculateMaterialPayment()
        {
            return 0;
        }

        public void AddPerson(Person person)
        {
            
        }

        public bool RemovePerson(Person person)
        {
            return false;
        }
    }
}
