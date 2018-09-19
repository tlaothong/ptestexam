using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myAPI.Models;

namespace myAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Product> _myProducts;

        public ValuesController()
        {
            _myProducts = new List<Product>
            {
                new Product { Id = "p01", Name = "LG TV", SerialNumber = "LG1234", Price = 15900 },
                new Product { Id = "p02", Name = "iPhone Z", SerialNumber = "PZ3452", Price = 39990 },
            };
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _myProducts;
        }

        [HttpGet("{key}")]
        public int CalculateTotalPrice(string key, int quantity)
        {
            const int defaultReturnValue = 0;
            const int minimumQuantity = 1;
            var isValid = !string.IsNullOrWhiteSpace(key) && quantity >= minimumQuantity;
            if (!isValid) return defaultReturnValue;

            int.TryParse(key, out int convertToPrice);
            Product result = null;
            if (convertToPrice >= minimumQuantity)
            {
                result = _myProducts.FirstOrDefault(it => it.Price == convertToPrice);
            }

            if (result == null) result = _myProducts.FirstOrDefault(it => it.Name.Contains(key, StringComparison.CurrentCultureIgnoreCase) || it.SerialNumber.Contains(key, StringComparison.CurrentCultureIgnoreCase));
            return result != null ? result.Price * quantity : defaultReturnValue;

        }

    }
}
