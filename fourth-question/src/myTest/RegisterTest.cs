using System;
using Xunit;
using myAPI.Controllers;
using myAPI.Models;
using System.Linq;

namespace myTest
{
    public class RegisterTest
    {
        private ValuesController _myApi;

        public RegisterTest()
        {
            _myApi = new ValuesController();
            _myApi.RegisterProduct(new Product { Id = "p01", Name = "LG TV", SerialNumber = "LG1234", Price = 15900 });
            _myApi.RegisterProduct(new Product { Id = "p02", Name = "iPhone Z", SerialNumber = "PZ3452", Price = 39990 });
        }

        [Theory]
        [InlineData("Jar", "Jar05x", 50)]
        [InlineData("Jar Ulimate", "Jar05xU", 599999999)]
        public void RegisterProduct_Success(string name, string serial, int price)
        {
            var product = new Product { Name = name, SerialNumber = serial, Price = price };
            var result = _myApi.RegisterProduct(product);
            Assert.True(result);
        }

        [Theory]
        [InlineData("", "Jar05x", 50)]
        [InlineData(null, "Jar05x", 50)]
        [InlineData("Jar", "", 50)]
        [InlineData("Jar", null, 50)]
        [InlineData("Jar", "Jar05x", 0)]
        [InlineData("Jar", "Jar05x", -1)]
        public void RegisterProduct_Failed(string name, string serial, int price)
        {
            var product = new Product { Name = name, SerialNumber = serial, Price = price };
            var result = _myApi.RegisterProduct(product);
            Assert.False(result);
        }
    }
}
