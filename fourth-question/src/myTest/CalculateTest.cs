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
        [InlineData(new string[] { "p01" }, 15900)]
        [InlineData(new string[] { "p02" }, 39990)]
        [InlineData(new string[] { "p01", "p02" }, 55890)]
        public void Calculate_Success(string[] productIds, int expectedPrice)
        {
            var products = _myApi.GetProducts();
            var result = products.Where(it => productIds.Contains(it.Id)).Sum(it => it.Price);
            Assert.Equal(expectedPrice, result);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("productid-does-not-exist")]
        public void Calculate_Failed(string productId)
        {
            var products = _myApi.GetProducts();
            var result = products.FirstOrDefault(it => it.Id == productId);
            Assert.Null(result);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("productid-does-not-exist")]
        public void CalculateOneProduct_Failed(string productId)
        {
            var result = _myApi.GetProduct(productId);
            Assert.Null(result);
        }
    }
}
