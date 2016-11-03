using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class CampingSpot
    {
        //Properties
        /// <summary>
        /// Taken from the database.
        /// </summary>
        public SpotType SpotType { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public int SpotID { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public int Capacity { get; private set; }

        public bool Reserved { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spotType">The type of the spot</param>
        /// <param name="spotID">The ID of the spot</param>
        /// <param name="capacity">The amount of people a spot can hold</param>
        /// <param name="reserved">Reservation status of the spot</param>
        public CampingSpot(SpotType spotType, int spotID, int capacity, bool reserved)
        {
            SpotType = spotType;
            SpotID = spotID;
            Capacity = capacity;
            Reserved = reserved;
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
                reservation = "open";
            }

            return SpotID
                + " | " + SpotType
                + " | " + Capacity
                + " | " + reservation
                ;
        }
    }
}
