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
        private static IList<CreateNewPurchaseOrderRequest> purchasedList = new List<CreateNewPurchaseOrderRequest>();

        [HttpGet]
        public IEnumerable<ProductInfo> Get()
        {
            return products;
        }

        [HttpPost]
        public ProductInfo CreateNewProduct([FromBody]ProductInfoRequest data)
        {
            var customTagGroups = data.CustomTags.Split(',', StringSplitOptions.RemoveEmptyEntries);
            // var customTagQry = customTagGroups.Select(it =>
            // {
            //     var tagData = it.Split(':', StringSplitOptions.RemoveEmptyEntries);
            //     return new TagInfo
            //     {
            //         Name = tagData[0],
            //         Value = tagData[1]
            //     };
            // });

            var newProduct = new ProductInfo
            {
                Id = Guid.NewGuid().ToString(),
                Name = data.Name,
                Price = data.Price,
                CustomTags = Enumerable.Empty<TagInfo>().ToList()
                // CustomTags = customTagQry.ToList()
            };

            products.Add(newProduct);
            return newProduct;
        }

        [HttpPost("purchaseorder")]
        public void CreateNewPurchaseOrder([FromBody]CreateNewPurchaseOrderRequest req)
        {
            purchasedList.Add(req);
        }

        [HttpGet("purchasedhistory")]
        public IEnumerable<CreateNewPurchaseOrderRequest> GetPurchasedHistory()
        {
            return purchasedList;
        }
    }
}
