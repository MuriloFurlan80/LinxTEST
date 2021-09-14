using Bogus;
using FluentAssertions;
using SO.Domain.Entity;
using System;
using Xunit;

namespace SO.Test
{
    public class CostPurchaseTest : IDisposable
    {

        private Faker _faker;

        public CostPurchaseTest()
        {
            _faker = new Faker();
        }

        [Fact(DisplayName = "Should not create because product is null")]
        public void ShouldNotCreateInvalidProduct()
        {
            Product product = new(
                    _faker.Database.Random.Guid().ToString(),
                    _faker.Random.String2(0, 50),
                    decimal.Parse(_faker.Commerce.Price(2)),
                    _faker.Commerce.ProductDescription(),
                    _faker.Random.Int(1000)
                    );

            Action action = () => new CostPurchase(_faker.Random.Guid().ToString(), _faker.Random.Decimal(2), null);
            action.Should().Throw<ArgumentException>().Where(x => x.Message.Equals("Product invalid! Add a product."));
        }

        [Fact(DisplayName = "Should not create because value invalid")]
        public void ShouldNotCreateInvalidValue()
        {
            Product product = new(
                    _faker.Database.Random.Guid().ToString(),
                    _faker.Random.String2(0, 50),
                    decimal.Parse(_faker.Commerce.Price(2)),
                    _faker.Commerce.ProductDescription(),
                    _faker.Random.Int(1000)
                    );

            Action action = () => new CostPurchase(_faker.Random.Guid().ToString(), default, product.Id);
            action.Should().Throw<ArgumentException>().Where(x => x.Message.Equals("Value is not valid! Value has to be greater than zero."));
        }

        public void Dispose()
        {
            _faker = null;
        }
    }
}
