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
        private string Name { get; set; }
        private string Location { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private int MaxVisitors { get; set; }
        private int CurrentVisitors { get; set; }
        private decimal Price { get; set; }
        private Camping Camping { get; set; }

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

        public string ToString()
        {
            return "";
        }
    }
}
