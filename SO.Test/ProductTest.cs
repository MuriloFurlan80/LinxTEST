using Bogus;
using FluentAssertions;
using SO.Domain.Entity;
using System;
using Xunit;

namespace SO.Test
{
    public class ProductTest : IDisposable
    {
        private Faker _faker;

        public ProductTest()
        {
            _faker = new Faker();
        }

        [Fact(DisplayName = "Should throw exeption because name is not valid")]
        public void ShouldNotAceptedName()
        {
            Action action = () => new Product(
                 _faker.Database.Random.Guid().ToString(),
                 _faker.Random.String2(50, 60),
                 decimal.Parse(_faker.Commerce.Price(2)),
                 _faker.Commerce.ProductDescription(),
                 _faker.Random.Int(1000)
                 );

            action.Should().Throw<ArgumentException>().Where(x => x.Message.Equals("Out of Range name product!"));
        }

        [Fact(DisplayName = "Should throw exeption because description is not valid")]
        public void ShouldNotAceptedDescription()
        {
            Action action = () => new Product(
                 _faker.Database.Random.Guid().ToString(),
                _faker.Random.String2(0, 50),
                 decimal.Parse(_faker.Commerce.Price(2)),
                 _faker.Random.String2(200, 260),
                 _faker.Random.Int(1000)
                 );

            action.Should().Throw<ArgumentException>().Where(x => x.Message.Equals("Out of Range description product!"));
        }

        public void Dispose()
        {
            _faker = null;
        }
    }
}
