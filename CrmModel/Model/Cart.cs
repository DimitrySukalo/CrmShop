using System;
using System.Collections.Generic;

namespace CrmModel.Model
{
    public class Cart
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public decimal Price { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public Cart(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("Customer cannot be null.", nameof(customer));
            }
            Customer = customer;
            Products = new List<Product>();
        }

        public void Add(Product product)
        {
            if(product != null)
            {
                Products.Add(product);
                Price += product.Price;
            }
        }

    }
}
