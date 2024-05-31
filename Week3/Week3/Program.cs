using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Apple", 2.5m, new DateTime(2024, 5, 1),1, true);
            Product product2 = new Product("Banana", 1.8m, new DateTime(2024, 5, 5),2, true);
            Product product3 = new Product("Milk", 1.0m, new DateTime(2024, 4, 30),4, true);
 
            Store store = new Store();

            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);

            Console.WriteLine("Searching for product 'Banana':");
            store.SearchProduct("Banana");

            Console.WriteLine("Adding quantity for product 'Banana':");
            store.AddQuantityOfProduct("Banana", 10);

            Console.WriteLine("Removing product 'Banana':");
            store.RemoveProduct(product2);




        }

    }
}

