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
        public static List<Product> _myProducts = new List<Product>();

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _myProducts;
        }

        [HttpPost]
        public bool RegisterProduct([FromBody]Product model)
        {
            const int minimumPrice = 0;
            var isValid = model != null &&
             !string.IsNullOrWhiteSpace(model.Name) &&
             !string.IsNullOrWhiteSpace(model.SerialNumber) &&
              model.Price > minimumPrice;
            if (!isValid) return false;

            model.Id = Guid.NewGuid().ToString();
            _myProducts.Add(model);
            return true;
        }

        [HttpGet("{key}/{quantity}")]
        public CalculateResult CalculateTotalPrice(string key, int quantity)
        {
            const int defaultReturnValue = 0;
            const int minimumQuantity = 1;
            var isValid = !string.IsNullOrWhiteSpace(key) && quantity >= minimumQuantity;
            if (!isValid) return null;

            int.TryParse(key, out int convertToPrice);
            Product result = null;
            if (convertToPrice >= minimumQuantity)
            {
                result = _myProducts.FirstOrDefault(it => it.Price == convertToPrice);
            }

            if (result == null) result = _myProducts.FirstOrDefault(it => it.Name.Contains(key, StringComparison.CurrentCultureIgnoreCase) || it.SerialNumber.Contains(key, StringComparison.CurrentCultureIgnoreCase));
            return new CalculateResult
            {
                ProductDetail = result,
                TotalPrice = result != null ? result.Price * quantity : defaultReturnValue
            };

        }

    }
}
