using System;

namespace SO.Domain.Entity
{
    public class SalePrice : EntityBase
    {
        public Product Product { get; private set; }
        public string ProductId { get; private set; }
        public decimal? ProfitMargin { get; private set; }
        public decimal Value { get; private set; }

        public SalePrice(string id) : base(id)
        {
        }

        public SalePrice(string id, Product product, decimal? profitMargin, decimal value) : this(id)
        {
            Product = product;
            ProfitMargin = profitMargin;
            Value = value;
        }

        public decimal SalePriceCalculate(CostPurchase cost, ExpenseTotal expenseTotal, int quantityProduct)
        {
            var expense = expenseTotal.Apportionment(quantityProduct);
            var price = cost.CalculateValueProduct();
            price += expense;
            price *= (1 + this.ProfitMargin.GetValueOrDefault() / 100);
            return price;
        }
    }
}
