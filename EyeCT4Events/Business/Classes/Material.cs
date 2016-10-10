using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Material
    {
        public string Name { get; set; }
        public MaterialType MaterialType { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool IsPayed { get; set; }

        public Material(string name, MaterialType materialType, int stock, decimal price, bool isPayed)
        {
            Name = name;
            MaterialType = materialType;
            Stock = stock;
            Price = price;
            IsPayed = isPayed;
        }
    }
}
