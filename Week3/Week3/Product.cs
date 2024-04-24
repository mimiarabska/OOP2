using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Product
    {
        private string name;
        private decimal price;
        private DateTime dateOfExpiring;
        private int quantity;
        private bool available;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 3)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                }
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value > 0 )
                {
                    this.price = value;
                }
                else
                {
                    Console.WriteLine("Invalid price");
                }
            }
        }
        public DateTime DateOfExpiring
        {
            get { return dateOfExpiring; }
            set
            {
                if (value >= DateTime.UtcNow)
                {
                    this.dateOfExpiring = value;
                }
                else
                {
                    Console.WriteLine("Invalid date of expiring");
                }
            }
        }
        public bool IsAvaliable
        {
            get { return this.available; }
            set { this.available = value;  }

        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity > 0)
                {
                    quantity = value;
                }
                else
                {
                    Console.WriteLine("Quantity is 0 or imposible");
                }

            }
        }
        public Product(string name, decimal price, DateTime dateOfExpiring ,int quantity, bool available )
        {
            this.name = name;
            this.price = price;
            this.dateOfExpiring = dateOfExpiring;
            this.available = available;
        }

    }
}
