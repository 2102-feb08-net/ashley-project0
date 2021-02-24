using System;
using Xunit;
using SlithyToves.DataAccess;
using SlithyToves.Library;

namespace SlithyToves.Tests
{
    public class RepositoryTests
    {
        [Fact]
        public void GetCustomerById()
        {
            // arrange
            var context = new SlithyTovesContext();
            var repository = new Repository(context);
            var expected = new Library.Models.CustomerModel("Ashley", "Brown");

            // act
            var actual = repository.GetCustomerById(1);

            // assert
            Assert.True(actual.CustomerId.Equals(expected.CustomerId));
        }
    }
}
