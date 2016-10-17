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
        private List<CampingSpot> campingSpots;

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
                if (value < 0) { throw new ArgumentOutOfRangeException("places"); }
                places = value;
            }
        }

        public List<CampingSpot> CampingSpots
        {
            get { return campingSpots; }
            set { campingSpots = value; }
        }

        //Constructor
        public Camping(string name, int places)
        {
            Name = name;
            Places = places;
            CampingSpots = new List<CampingSpot>();
        }

        //Methods
        public bool AddSpot(CampingSpot spot)
        {
            foreach (CampingSpot sp in CampingSpots)
            {
                if (sp == spot)
                {
                    return false;
                }
            }
            campingSpots.Add(spot);
            return true;
        }

        public bool ModifySpot(CampingSpot oldSpot, CampingSpot newSpot)
        {
            foreach (CampingSpot sp in campingSpots)
            {
                if (sp == oldSpot)
                {
                    int index = campingSpots.IndexOf(sp);
                    if (index != -1)
                    {
                        campingSpots[index] = newSpot;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool RemoveSpot(CampingSpot spot)
        {
            foreach (CampingSpot sp in campingSpots)
            {
                if (sp == spot)
                {
                    campingSpots.Remove(sp);
                    return true;
                }
            }
            return false;
        }

        public CampingSpot FindSpot(CampingSpot spot)
        {
            foreach (CampingSpot sp in campingSpots)
            {
                if (sp == spot)
                {
                    return sp;
                }
            }
            return null;
        }
    }
}
