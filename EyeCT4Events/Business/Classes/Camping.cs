using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Camping
    {
        //Properties
        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public List<CampingSpot> CampingSpots { get; private set;}

        public int Places { get { return CampingSpots.Count; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the Camping</param>
        /// <param name="places">How many spots the camping has</param>
        public Camping(string name, string address)
        {
            Name = name;
            Address = address;
            CampingSpots = new List<CampingSpot>();
        }

        /// <summary>
        /// Find a Camping Spot
        /// </summary>
        /// <param name="spot">The Camping Spot that has to be found</param>
        /// <returns></returns>
        public CampingSpot FindSpot(int spotID)
        {
            foreach (CampingSpot found in CampingSpots)
            {
                if (found.SpotID == spotID)
                {
                    return found;
                }
            }
            return null;
        }



    }
}
