using SO.Domain.Entity;
using System;

namespace SO.Test
{
    public class SalePrice : EntityBase
    {
        public Product Product { get; set; }
        public decimal? ProfitMargin { get; set; }
        public decimal Value { get; set; }

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
