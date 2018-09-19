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
        [InlineData("LG", 1, 15900)]
        [InlineData(" TV", 1, 15900)]
        [InlineData("1234", 2, 31800)]
        [InlineData("iPhone ", 1, 39990)]
        [InlineData("z", 1, 39990)]
        [InlineData("z345", 4, 159960)]
        [InlineData("39990", 1, 39990)]
        public void Calculate_Success(string productId, int quantity, int expectedPrice)
        {
            var result = _myApi.CalculateTotalPrice(productId, quantity);
            Assert.Equal(expectedPrice, result.TotalPrice);
        }

        [Theory]
        [InlineData(" ", 1)]
        [InlineData("", 1)]
        [InlineData(null, 1)]
        [InlineData("LG", 0)]
        public void Calculate_Failed(string productId, int quantity)
        {
            var result = _myApi.CalculateTotalPrice(productId, quantity);
            Assert.Null(result);
        }

        [Theory]
        [InlineData("productid-does-not-exist", 1)]
        public void Calculate_ProductDoesNotExist(string productId, int quantity)
        {
            var result = _myApi.CalculateTotalPrice(productId, quantity);
            Assert.Null(result.ProductDetail);
        }
    }
}
