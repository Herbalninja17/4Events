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
        public List<Camping> Campings { get; set; }

        public Maintain()
        {
            Events = new List<Event>();
            Persons = new List<Person>();
        }

        public bool AddPerson(Person person)
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

        public bool ModifyPerson(Person oldPerson, Person newPerson)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == oldPerson.Email)
                {
                    int index = Persons.IndexOf(oldPerson);
                    Persons[index] = newPerson;
                    return true;
                }
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


        public Person FindPerson(Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == person.Email)
                {
                    return p;
                }
            }
            return null;
        }

        public bool AddReservationToPerson(Reservation reservation, Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == person.Email)
                {
                    p.Reservations.Add(reservation);
                    return true;
                }
            }
            return false;
        }

        public bool ModifyReservation(Reservation oldReservation, Reservation newReservation, Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == person.Email)
                {
                    foreach (Reservation r in p.Reservations)
                    {
                        if (r == oldReservation)
                        {
                            int index = p.Reservations.IndexOf(oldReservation);
                            if (index != -1)
                            {
                                p.Reservations[index] = newReservation;
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public bool DeleteReservation(Reservation reservation, Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == person.Email)
                {
                    foreach (Reservation r in p.Reservations)
                    {
                        if (r == reservation)
                        {
                            p.Reservations.Remove(r);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public Reservation FindReservation(Reservation reservation, Person person)
        {
            foreach (Person p in Persons)
            {
                if (p.Email == person.Email)
                {
                    foreach (Reservation r in p.Reservations)
                    {
                        if (r == reservation)
                        {
                            return r;
                        }
                    }
                }
            }
            return null;
        }

        public bool AddEvent(Event eEvent)
        {
            foreach (Event e in Events)
            {
                if (e == eEvent)
                {
                    return false;
                }
            }

            Events.Add(eEvent);
            return true;
        }

        public bool ModifyEvent(Event oldeEvent, Event neweEvent)
        {
            foreach (Event e in Events)
            {
                if (e == oldeEvent)
                {
                    int index = Events.IndexOf(oldeEvent);
                    if (index != -1)
                    {
                        Events[index] = neweEvent;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DeleteEvent(Event eEvent)
        {
            foreach (Event e in Events)
            {
                if (e == eEvent)
                {
                    Events.Remove(e);
                    return true;
                }
            }

            return false;
        }

        public Event FindEvent(Event eEvent)
        {
            foreach (Event e in Events)
            {
                if (e == eEvent)
                {
                    return e;
                }
            }
            return null;
        }

        public bool AddCamping(Camping camping)
        {
            foreach (Camping found in Campings)
            {
                if (found.Name == camping.Name && found.Address == camping.Address)
                {
                    return false;
                }
            }
            Campings.Add(camping);
            return true;
        }
    }
}
