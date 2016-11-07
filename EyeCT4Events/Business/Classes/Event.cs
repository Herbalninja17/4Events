using EyeCT4Events.Data.DataClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Event
    {
        //fields (Used to check for exceptions in the propperties).
        private string name;
        private DateTime startDate;
        private DateTime endDate;
        private Camping camping;

        //Properties
        public string Name
        {
            get
            { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("name"); }
                    throw new ArgumentException("name");
                }
                name = value;
            }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                DateTime today = DateTime.Today;
                if(value <= today) { throw new ArgumentOutOfRangeException("startDate"); }
                startDate = value; //May not be today or sooner.
            }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if(value < startDate) { throw new ArgumentOutOfRangeException("startDate"); }
                endDate = value; //May be the same as the start date but not sooner.
            }
        }

        public int MaxVisitors { get { return camping.Places; } }

        /// <summary>
        /// Take from dropdownbox
        /// </summary>
        public Camping Camping
        {
            get { return camping; }
            set
            {
                if (value == null) { throw new ArgumentNullException("camping"); }
                camping = value;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of the event.</param>
        /// <param name="startDate">Start date for the event.</param>
        /// <param name="endDate">End date of the event.</param>
        /// <param name="camping">Camping object for the event.</param>
        public Event(string name, DateTime startDate, DateTime endDate, Camping camping)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Camping = camping; //Take from dropdownbox.
        }

        //Methods
        public override string ToString()
        {
            return Name
                + " | " + StartDate.ToString("d-M-yyyy")
                + " | " + EndDate.ToString("d-M-yyyy")
                + " | " + MaxVisitors
                + " | " + CurrentVisitors
                + " | " + Camping.Name
                ;
        }
    }
}