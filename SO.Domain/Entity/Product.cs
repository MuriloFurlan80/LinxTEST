using SO.Domain.Utils.Exceptions;
using System;

namespace SO.Domain.Entity
{
    public class Product : EntityBase
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public Store Store { get; private set; }
        public string StoreId { get; private set; }
        public SalePrice SalePrice { get; private set; }
        public CostPurchase CostPurchase { get; private set; }
        public Photo Photo { get; private set; }
        public Product(string id) : base(id)
        {
        }

        public Product(string id, string name, decimal price, string description, int quantity) : this(id)
        {
            DomainException.When(string.IsNullOrEmpty(name) || name.Length > 50, "Out of Range name product!");
            DomainException.When(string.IsNullOrEmpty(description) || description.Length > 200, "Out of Range description product!");
            Name = name;
            Price = price;
            Description = description;
            Quantity = quantity;
        } 
        
        public Product(string id, string name, decimal price, string description, int quantity, string storeId) : this(id, name, price, description, quantity)
        {
            StoreId = storeId;
        } 
        public Product(string id, string name, decimal price, string description, int quantity, string storeId, Photo photo) : this(id, name, price, description, quantity, storeId)
        {
            Photo = photo;
        }
    }
}
