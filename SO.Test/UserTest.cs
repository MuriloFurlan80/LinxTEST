using Bogus;
using FluentAssertions;
using SO.Domain.Entity;
using System;
using Xunit;

namespace SO.Test
{
    public class UserTest : IDisposable
    {
        private Faker _faker;
        public UserTest()
        {
            _faker = new Faker();
        }

        [Fact(DisplayName ="Should not create user if name is greater 200")]
        public void ShouldNotCreateUser()
        {
            Action act = () => new User(_faker.Random.Guid().ToString(), _faker.Random.String(201, 210));
            act.Should().Throw<ArgumentException>().Where(x => x.Message.Equals("Out of Range name user!"));
        }

        public void Dispose()
        {
            _faker = null;
        }
    }
}
