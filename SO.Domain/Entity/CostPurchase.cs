using SO.Domain.Utils.Exceptions;
using System;

namespace SO.Domain.Entity
{
    public class CostPurchase : EntityBase
    {
        public decimal Value { get; private set; }
        public Product Product { get; private set; }
        public string ProductId { get; private set; }

        public CostPurchase(string id) : base(id)
        {
        }

        public CostPurchase(string id, decimal value, string productId) : this(id)
        {
            DomainException.When(value is default(decimal), "Value is not valid! Value has to be greater than zero.");
            DomainException.When(string.IsNullOrEmpty(productId), "Product invalid! Add a product.");
            Value = value;
            ProductId = productId;
        }

        public decimal CalculateValueProduct() 
        {
            return this.Product.Price - this.Value;
        }
    }
}
