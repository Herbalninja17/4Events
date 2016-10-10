using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class CampingSpot
    {
        public SpotType SpotType { get; set; }
        public int SpotID { get; set; }
        public int Capacity { get; set; }
        public bool Reserved { get; set; }

        public CampingSpot(SpotType spotType, int spotID, int capacity)
        {
            SpotType = spotType;
            SpotID = spotID;
            Capacity = capacity;
            Reserved = false;
        }
    }
}
