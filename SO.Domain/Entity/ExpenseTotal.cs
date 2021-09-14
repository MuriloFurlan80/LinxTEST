using System;

namespace SO.Domain.Entity
{
    public class ExpenseTotal : EntityBase
    {
        public decimal Value { get; private set; }
        public Store Store { get; private set; }
        public string StoreId { get; private set; }
        public ExpenseTotal(string id) : base(id)
        {

        }
        public ExpenseTotal(string id, decimal value) : this(id)
        {
            Value = value;
        }

        public decimal Apportionment(int product)
        {
            if (this.Value is default(decimal))
                this.Value = 400M;

            if (product is default(int))
                throw new ArgumentException("Quantity of Product is not valid!");

            return this.Value / product;
        }
    }
}
