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
        private string location;
        private DateTime startDate;
        private DateTime endDate;
        private int maxVisitors;
        private int currentVisitors;
        private decimal price;
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
        public string Location
        {
            get { return location; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("location"); }
                    throw new ArgumentException("location");
                }
                location = value;
            }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            private set
            {
                DateTime today = DateTime.Today;
                if(value <= today) { throw new ArgumentOutOfRangeException("startDate"); }
                startDate = value; //May not be today or sooner.
            }
        }

        private DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if(value < startDate) { throw new ArgumentOutOfRangeException("startDate"); }
                endDate = value; //May be the same as the start date but not sooner.
            }
        }

        public int MaxVisitors
        {
            get { return maxVisitors; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("maxVisitors"); }
                maxVisitors = value;
            }
        }

        public int CurrentVisitors
        {
            get { return currentVisitors; }
            set
            {
                if (value < 0 || value > MaxVisitors) { throw new ArgumentOutOfRangeException("currentVisitors"); }
                currentVisitors = value;
            }
        }


        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("price"); }
                price = value;
            }
        }

        public Camping Camping
        {
            get { return camping; }
            set
            {
                if (value == null) { throw new ArgumentNullException("camping"); }
                camping = value;
            }
        }

        //Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of the event.</param>
        /// <param name="location">Location of the event.</param>
        /// <param name="startDate">Start date for the event.</param>
        /// <param name="endDate">End date of the event.</param>
        /// <param name="maxVisitors">Maximum number of people that may come to the event.</param>
        /// <param name="price">Price for the event.</param>
        /// <param name="camping">Camping object for the event.</param>
        public Event(string name, string location, DateTime startDate, DateTime endDate, int maxVisitors, decimal price, Camping camping)
        {
            Name = name;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
            MaxVisitors = maxVisitors;
            CurrentVisitors = 0;
            Price = price;
            Camping = camping;
        }

        //Methods
        public string ToString()
        {
            return Name
                + " | " + Location
                + " | " + StartDate
                + " | " + EndDate
                + " | " + MaxVisitors
                + " | " + CurrentVisitors
                + " | " + Price
                + " | " + Camping.Name
                ;
        }
    }
}
