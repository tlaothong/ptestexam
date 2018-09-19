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

        [HttpGet("{id}")]
        public Product GetProduct(string key)
        {
            var isValid = !string.IsNullOrWhiteSpace(key);
            if (!isValid) return null;

            int.TryParse(key, out int convertToPrice);
            Product result = null;
            if (convertToPrice > 0)
            {
                result = _myProducts.FirstOrDefault(it => it.Price == convertToPrice);
            }
            
            if (result != null) return result;
            else return _myProducts.FirstOrDefault(it => it.Name.Contains(key, StringComparison.CurrentCultureIgnoreCase) || it.SerialNumber.Contains(key, StringComparison.CurrentCultureIgnoreCase));

        }

    }
}
