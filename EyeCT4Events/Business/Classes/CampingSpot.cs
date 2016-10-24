using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class CampingSpot
    {
        //Fields
        private int spotID;
        private int capacity;

        //Properties
        public SpotType SpotType { get; set; }

        public int SpotID
        {
            get { return spotID; }
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException("spotID"); }
                spotID = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException("capacity");}
                capacity = value;
            }
        }

        public bool Reserved { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spotType">The type of the spot</param>
        /// <param name="spotID">The ID of the spot</param>
        /// <param name="capacity">The amount of people a spot can hold</param>
        public CampingSpot(SpotType spotType, int spotID, int capacity)
        {
            SpotType = spotType;
            SpotID = spotID;
            Capacity = capacity;
            Reserved = false;
        }

        public override string ToString()
        {
            string reservation = "";
            if(Reserved)
            {
                reservation = "reserved";
            }
            else
            {
                reservation = "free";
            }

            return SpotID
                + " | " + SpotType
                + " | " + Capacity
                + " | " + reservation
                ;
        }
    }
}
