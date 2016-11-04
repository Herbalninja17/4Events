using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Material
    {

        //Properties
        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Name { get; private set; }
        

        public DateTime HuurdatumStart  { get; private set; }

        public DateTime HuurdatumEind { get; set; }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public decimal Price { get; private set; }

        public bool Rented { get; set; }

        public bool IsPayed { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Material name.</param>
        /// <param name="materialType">Enum: material Type.</param>
        /// <param name="stock">Amount in stock</param>
        /// <param name="price">price per item.</param>
        /// <param name="isPayed">True: Item is payed for, False: Item is not payed for.</param>
        public Material(string name, decimal price, bool isPayed)
        {
            Name = name;
            Price = price;
            IsPayed = isPayed;
        }

        //Methods
        public void StartHuur(DateTime eindDatum)
        {
            if(eindDatum < DateTime.Now) { throw new ArgumentOutOfRangeException("eindDatum"); }

            HuurdatumStart = DateTime.Now;
            HuurdatumEind = eindDatum;
        }

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
                + " | " + Price
                + " | " + payedString
                ;
        }
    }
}
