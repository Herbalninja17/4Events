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
        private SpotType spotType;
        private int spotID;
        private int capacity;
        private bool reserved;

        //Properties
        public SpotType SpotType
        {
            get { return spotType; }
            set { spotType = value; }
        }

        public int SpotID
        {
            get { return spotID; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("spotID"); }
                spotID = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("capacity");}
                capacity = value;
            }
        }

        public bool Reserved
        {
            get { return reserved; }
            set { reserved = false; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spotType">The type of the spot</param>
        /// <param name="spotID">The ID of the spot</param>
        /// <param name="capacity">The amount of people a spot can hold</param>
        public CampingSpot(SpotType spotType, int spotID, int capacity)
        {
            this.spotType = spotType;
            this.spotID = spotID;
            this.capacity = capacity;
            this.reserved = false;
        }
    }
}
