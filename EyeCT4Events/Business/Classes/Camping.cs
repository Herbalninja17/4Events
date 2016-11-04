using EyeCT4Events.Data.DataClasses;
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
        public string City { get; private set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Zipcode { get; private set; }

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
        public Camping(string name, string address, string city, string zipcode)
        {
            Name = name;
            Address = address;
            City = city;
            Zipcode = zipcode;
            CampingSpots = DataCampingSpot.GetCampingSpotList();
        }

        /// <summary>
        /// Find all free camping spots of a certain type.
        /// </summary>
        /// <param name="type">Filtertype for the campingspot.</param>
        /// <returns></returns>
        public List<CampingSpot> FreeCampingSpots(SpotType type)
        {
            List<CampingSpot> campingSpots = null;

            foreach (CampingSpot found in CampingSpots)
            {
                if (!found.Reserved && found.SpotType == type)
                {
                    campingSpots.Add(found);
                }
            }
            return campingSpots;
        }

        /// <summary>
        /// Gives all free camping spots.
        /// </summary>
        /// <returns>List of free camping spots.</returns>
        public List<CampingSpot> FreeCampingSpots()
        {
            List<CampingSpot> campingSpots = null;

            foreach(CampingSpot found in CampingSpots)
            {
                if(!found.Reserved)
                {
                    campingSpots.Add(found);
                }
            }
            return campingSpots;
        }

        /// <summary>
        /// Gives all reserved camping spots.
        /// </summary>
        /// <returns>list of reserved camping spots.</returns>
        public List<CampingSpot> ReservedCampingSpots()
        {
            List<CampingSpot> campingSpots = null;

            foreach (CampingSpot found in CampingSpots)
            {
                if (found.Reserved)
                {
                    campingSpots.Add(found);
                }
            }
            return campingSpots;
        }

        /// <summary>
        /// Calls the Data layer method to reserve a specific camping spot.
        /// </summary>
        /// <param name="spotID"></param>
        public void CampingSpotReservation(int spotID)
        {
            DataCampingSpot.ReserveCampingSpot(spotID);     
        }
    }
}
