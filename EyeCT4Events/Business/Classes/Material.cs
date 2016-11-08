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
        public int ID { get; private set; }  

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Name { get; private set; } 

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public string Description { get; set; }  

        /// <summary>
        /// Taken from the database. Is set when an enddate for the lease is set.
        /// </summary>
        public DateTime LeaseDateStart  { get; private set; } 

        /// <summary>
        /// Can be set to make a lease (starting at today).
        /// </summary>
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
        /// <param name="id">Material id, different for each specific material.</param>
        /// <param name="name">Material name.</param>
        /// <param name="description">Description for the material (eg: size).</param>
        /// <param name="price">Price per item.</param>
        /// <param name="isPayed">true: Item is payed for | false: Item is not payed for.</param>
        /// <param name="leased">true: someone is currently borrowing this item | false: this item is available.</param>
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

        /// <summary>
        /// To start the lease of this item.
        /// The lease will start upon activating this method.
        /// </summary>
        /// <param name="endDate">Date the item has to be returned.</param>
        public void StartLease(DateTime endDate) 
        {
            if(endDate < DateTime.Today) { throw new ArgumentOutOfRangeException("endDate"); }

            LeaseDateStart = DateTime.Today;
            LeaseDateEnd = endDate;
            Leased = true;
        }

        /// <summary>
        /// Ends the lease for this item and makes it available for lease again.
        /// </summary>
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
