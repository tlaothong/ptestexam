using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using storewebapi.Models;

namespace storewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POSController : ControllerBase
    {
        private static IList<ProductInfo> products = new List<ProductInfo>();

        [HttpGet]
        public IEnumerable<ProductInfo> Get()
        {
            return products;
        }

        [HttpPost]
        public ProductInfo CreateNewProduct(ProductInfoRequest data)
        {
            var customTagGroups = data.CustomTags.Split(',', StringSplitOptions.RemoveEmptyEntries);
            var customTagQry = customTagGroups.Select(it =>
            {
                var tagData = it.Split(':', StringSplitOptions.RemoveEmptyEntries);
                return new KeyValuePair<string, string>(tagData[0], tagData[1]);
            });

            var customTags = new Dictionary<string, string>();
            foreach (var item in customTagQry)
            {
                if (customTags.ContainsValue(item.Key)) continue;
                customTags.Add(item.Key, item.Value);
            }

            var newProduct = new ProductInfo
            {
                Id = Guid.NewGuid().ToString(),
                Name = data.Name,
                Price = data.Price,
                CustomTags = customTags
            };

            products.Add(newProduct);
            return newProduct;
        }
    }
}
