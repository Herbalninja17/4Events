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
        public int ID { get; private set; }  
        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Name { get; private set; } 

        public string Description { get; set; }  

        public DateTime LeaseDateStart  { get; private set; } 

        public DateTime LeaseDateEnd { get; set; } 

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public decimal Price { get; private set; } 

        public bool Leased { get; set; } 

        public bool IsPayed { get; set; } 

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Material name.</param>
        /// <param name="materialType">Enum: material Type.</param>
        /// <param name="stock">Amount in stock</param>
        /// <param name="price">price per item.</param>
        /// <param name="isPayed">True: Item is payed for, False: Item is not payed for.</param>
        public Material(int id, string name, string description, decimal price, bool isPayed, bool leased) 
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            IsPayed = isPayed;
            Leased = leased;
        }

        //Methods
        public void StartLease(DateTime endDate) 
        {
            if(endDate < DateTime.Today) { throw new ArgumentOutOfRangeException("endDate"); }

            LeaseDateStart = DateTime.Today;
            LeaseDateEnd = endDate;
            Leased = true;
        }

        public void StopLease()
        {
            Leased = false;
        }

        public override string ToString() 
        {
            return $"{Name} | {Description} | {Price}";
        }
    }
}
