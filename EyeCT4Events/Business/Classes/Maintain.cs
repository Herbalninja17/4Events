using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Maintain
    {
        public List<Event> Events { get; set; }
        public List<Person> Persons { get; set; }

        public Maintain()
        {
            Events = new List<Event>();
            Persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            
        }

        public void ModifyPerson(Person person)
        {
            
        }

        public bool RemovePerson(Person person)
        {
            return false;
        }

        public void AddReservationToPerson(Reservation reservation, Person person)
        {
            
        }

        public void ModifyReservation(Reservation reservation)
        {
            
        }

        public bool DeleteReservation(Reservation reservation)
        {
            return false;
        }

        public Reservation FindReservation(Reservation reservation)
        {
            return null;
        }

        public void AddEvent(Event eEvent)
        {
            
        }

        public void ModifyEvent(Event eEvent)
        {
            
        }

        public bool DeleteEvent(Event eEvent)
        {
            return false;
        }

        public Event FindEvent(Event eEvent)
        {
            return null;
        }
    }
}
