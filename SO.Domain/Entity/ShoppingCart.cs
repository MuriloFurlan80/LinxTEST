using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.Domain.Entity
{
    public class ShoppingCart:EntityBase
    {
        public Product Product { get; private set; }
        public string ProductId { get; private set; }
        public User User { get; private set; }
        public string UserId { get; private set; }
        public int Quantity { get; private set; }

        public ShoppingCart(string id):base(id)
        { 
        }

        public ShoppingCart(string id, Product product,User user, int quantity):this(id)
        {
            Product = product;
            User = user;
            Quantity = quantity;
        }
    }
}
