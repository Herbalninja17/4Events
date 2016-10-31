using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Camping
    {
        //Fields
        private string name;
        private int places;

        //Properties
        public string Name
        {
            get { return name; }
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

        public int Places
        {
            get { return places; }
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException("places"); }
                places = value;
            }
        }

        public List<CampingSpot> CampingSpots { get; set;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the Camping</param>
        /// <param name="places">How many spots the camping has</param>
        public Camping(string name, int places)
        {
            Name = name;
            Places = places;
            CampingSpots = new List<CampingSpot>();
        }

        /// <summary>
        /// Add a Camping Spot
        /// </summary>
        /// <param name="spot">Camping spot that has to be made</param>
        /// <returns></returns>
        public bool AddSpot(CampingSpot spot)
        {
            foreach (CampingSpot sp in CampingSpots)
            {
                if (sp.SpotID == spot.SpotID)
                {
                    return false;
                }
            }
            CampingSpots.Add(spot);
            return true;
        }

        /// <summary>
        /// Modify a Camping Spot
        /// </summary>
        /// <param name="oldSpot">The old spot that has to be modified</param>
        /// <param name="newSpot">The new spot that has to replace the old spot</param>
        /// <returns></returns>
        public bool ModifySpot(CampingSpot oldSpot, CampingSpot newSpot)
        {
            foreach (CampingSpot sp in CampingSpots)
            {
                if (sp.SpotID == oldSpot.SpotID)
                {
                    sp.Capacity = newSpot.Capacity;
                    sp.Reserved = newSpot.Reserved;
                    sp.SpotID = newSpot.SpotID;
                    sp.SpotType = newSpot.SpotType;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Remove a Camping Spot
        /// </summary>
        /// <param name="spot">The Camping Spot that has to be removed</param>
        /// <returns></returns>
        public bool RemoveSpot(CampingSpot spot)
        {
            foreach (CampingSpot sp in CampingSpots)
            {
                if (sp.SpotID == spot.SpotID)
                {
                    CampingSpots.Remove(sp);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Find a Camping Spot
        /// </summary>
        /// <param name="spot">The Camping Spot that has to be found</param>
        /// <returns></returns>
        public CampingSpot FindSpot(CampingSpot spot)
        {
            foreach (CampingSpot sp in CampingSpots)
            {
                if (sp.SpotID == spot.SpotID)
                {
                    return sp;
                }
            }
            return null;
        }
    }
}
