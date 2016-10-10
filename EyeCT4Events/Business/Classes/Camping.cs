using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Camping
    {
        //Jethro Test

        //Properties
        public string Name { get; set; }
        public int Places { get; set; }
        public List<CampingSpot> CampingSpots { get; set; }

        //Constructor
        public Camping(string name, int places)
        {
            Name = name;
            Places = places;
            CampingSpots = new List<CampingSpot>();
        }

        //Methods
        public void AddSpot(CampingSpot spot)
        {
             
        }

        public void ModifySpot(CampingSpot spot)
        {
            
        }

        public void RemoveSpot(CampingSpot spot)
        {
            
        }

        public CampingSpot FindSpot(CampingSpot spot)
        {
            return null;
        }
    }
}
