using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Store
    {
        public List<Product> Products { get; set; }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        public void SearchProduct(string name)
        {
            var product = Products.FirstOrDefault(x => x.Name == name);
            Console.WriteLine("Product is in the list");

        }
        public void AddQuantityOfProduct(string name, int quantity)
        {
            var product = Products.FirstOrDefault(x => x.Name == name);
            product.Quantity = product.Quantity + quantity;
        }
        public void RemoveQuantityOfProduct(string name, int quantity)
        {
            var product = Products.FirstOrDefault(x => x.Name == name);
            product.Quantity = product.Quantity - quantity;

        }
    }
}
