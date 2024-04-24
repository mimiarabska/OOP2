using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Cart
    {
        private decimal total;

        public List<Product> Carts { get; set; }

        public decimal Total
        {
            get { return Carts.Select(x=> x.Price * x.Quantity).Sum(); }
        }

        public void RemoveProduct(List<Product> cart , Product product)
        {
            cart.Remove(product);
        }
        public void AddProduct(List<Product> cart, Product product)
        {
            cart.Add(product);
        }
       
    }
}
