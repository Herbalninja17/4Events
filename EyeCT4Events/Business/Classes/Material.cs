using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Material
    {
        //Fields
        private string name;
        private int stock;
        private decimal price;

        //Properties
        public string Name
        {
            get { return name; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    if(value == null) { throw new ArgumentNullException("name"); }
                    throw new ArgumentException("name");
                }
                name = value;
            }
        }

        public MaterialType MaterialType { get; set; }

        public int Stock
        {
            get { return stock; }
            set
            {
                if(value < 0) { throw new ArgumentOutOfRangeException("stock"); }
                stock = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("price"); }
                price = value;
            }
        }

        public bool IsPayed { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Material name.</param>
        /// <param name="materialType">Enum: material Type.</param>
        /// <param name="stock">Amount in stock</param>
        /// <param name="price">price per item.</param>
        /// <param name="isPayed">True: Item is payed for, False: Item is not payed for.</param>
        public Material(string name, MaterialType materialType, int stock, decimal price, bool isPayed)
        {
            Name = name;
            MaterialType = materialType;
            Stock = stock;
            Price = price;
            IsPayed = isPayed;
        }

        //Methods
        public override string ToString()
        {
            string payedString = "";
            if(IsPayed)
            {
                payedString = "Is betaald.";
            }
            else
            {
                payedString = "Niet betaald.";
            }

            return Name
                + " | " + MaterialType
                + " | " + Stock
                + " | " + Price
                + " | " + payedString
                ;
        }
    }
}
