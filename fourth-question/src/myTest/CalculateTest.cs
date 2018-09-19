using System;
using Xunit;
using myAPI.Controllers;
using System.Linq;

namespace myTest
{
    public class CalculateTest
    {
        private ValuesController _myApi;

        public CalculateTest()
        {
            _myApi = new ValuesController();
        }

        [Theory]
        [InlineData("LG", 15900)]
        [InlineData(" TV", 15900)]
        [InlineData("1234", 15900)]
        [InlineData("iPhone ", 39990)]
        [InlineData("z", 39990)]
        [InlineData("z345", 39990)]
        [InlineData("39990", 39990)]
        public void Calculate_Success(string productId, int expectedPrice)
        {
            var result = _myApi.GetProduct(productId);
            Assert.Equal(expectedPrice, result.Price);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("productid-does-not-exist")]
        public void Calculate_Failed(string productId)
        {
            var result = _myApi.GetProduct(productId);
            Assert.Null(result);
        }
    }
}
