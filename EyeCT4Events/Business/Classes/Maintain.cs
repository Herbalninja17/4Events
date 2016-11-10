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
        //Properties
        public List<Event> Events { get; set; }
        public List<Person> Persons { get; set; }
        public List<Camping> Campings { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Maintain()
        {
            Events = new List<Event>();
            Persons = new List<Person>();
            Campings = new List<Camping>();
        }

        //Methods

        /// <summary>
        /// To add a person to the persons list.
        /// </summary>
        /// <param name="person"></param>
        /// <returns>false: Person already exists | true: new person is added.</returns>
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

        /// <summary>
        /// To modify an existing person in the Persons list.
        /// </summary>
        /// <param name="oldPerson">Person to be changed.</param>
        /// <param name="newPerson">Person to change it into.</param>
        /// <returns>true: Person is changed | false: oldPerson did not exist.</returns>
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

        /// <summary>
        /// To remove a person from the Persons list.
        /// </summary>
        /// <param name="person">Person to remove from the Person list.</param>
        /// <returns>true: Person is removed | false: person was not in list.</returns>
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

        /// <summary>
        /// Finds a person in the persons list.
        /// </summary>
        /// <param name="person">Person to seek</param>
        /// <returns>Person: if the person exists in the Persons list | null: Person did not exist in the Persons list.</returns>
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

        /// <summary>
        /// To add a reservation to a person.
        /// </summary>
        /// <param name="reservation">Reservation to be added.</param>
        /// <param name="person">Person to add the reservation to.</param>
        /// <returns>true: Reservation is added | false: Person did not exist.</returns>
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

        /// <summary>
        /// Modifies a reservation of a person.
        /// </summary>
        /// <param name="oldReservation">Reservation to be modified.</param>
        /// <param name="newReservation">Modified reservation.</param>
        /// <param name="person">Person the reservation belongs to.</param>
        /// <returns>true: Reservation is modified | false: Person or the old reservation does not exist.</returns>
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

        /// <summary>
        /// To delete a reservation from a person.
        /// </summary>
        /// <param name="reservation">Reservation to be deleted.</param>
        /// <param name="person">Persen the reservation needs to be deleted from.</param>
        /// <returns>true: Reservation is deleted | false: Person or reservation does not exist.</returns>
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

        /// <summary>
        /// To find a reservation beloinging to a certain person.
        /// </summary>
        /// <param name="reservation">Reservation to seek.</param>
        /// <param name="person">Person to seek the reservation for.</param>
        /// <returns>Reservation: if the reservation was found for the specific person | Null: Reservation does not exist for the specific person.</returns>
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

        /// <summary>
        /// Adds an Event.
        /// </summary>
        /// <param name="eEvent">Event to add.</param>
        /// <returns>true: Event was added | false: Event already exists.</returns>
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

        /// <summary>
        /// To modify an event.
        /// </summary>
        /// <param name="oldeEvent">Event that needs to be modified</param>
        /// <param name="neweEvent">Event that the old event needs to be modified into.</param>
        /// <returns>true: Event is modified | false: old event does not exist.</returns>
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

        /// <summary>
        /// To delete an event.
        /// </summary>
        /// <param name="eEvent">Event to delete.</param>
        /// <returns>true: Event is removed | false: Event does not exist.</returns>
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

        /// <summary>
        /// To find an event.
        /// </summary>
        /// <param name="eEvent">Event to seek.</param>
        /// <returns>Event: if the event is found | null: the event does not exist.</returns>
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

        /// <summary>
        /// To add a camping.
        /// </summary>
        /// <param name="camping">Camping to be added</param>
        /// <returns>true: Camping is added | false: Camping already exists.</returns>
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
