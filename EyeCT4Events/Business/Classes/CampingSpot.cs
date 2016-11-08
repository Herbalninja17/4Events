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
        public int PlaceNr { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public int Capacity { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// Can be changed to reserve/unreserve a spot.
        /// </summary>
        public bool Reserved { get; set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spotType">The type of the spot</param>
        /// <param name="spotID">The ID of the spot</param>
        /// <param name="placeNr">Number of the place this spot is located</param>
        /// <param name="capacity">The amount of people a spot can hold</param>
        /// <param name="reserved">Reservation status of the spot</param>
        /// <param name="price">Price for the specific spot (set in the database)</param>
        public CampingSpot(SpotType spotType, int spotID, int placeNr, int capacity, bool reserved, decimal price)
        {
            SpotType = spotType;
            SpotID = spotID;
            PlaceNr = placeNr;
            Capacity = capacity;
            Reserved = reserved;
            Price = price;
        }

        //Methods

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
