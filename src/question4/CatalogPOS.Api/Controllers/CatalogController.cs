using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogPOS.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogPOS.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        public static List<Product> products = new List<Product>()
        {
            new Product{ Name = "LG TV", SerialNumber = "LG1234", UnitPrice = 15900},
            new Product{ Name = "iPhone Z", SerialNumber = "PZ3452", UnitPrice = 39990},
        };

        [HttpGet("{key}/{value}")]
        public ActionResult<IEnumerable<Product>> Search(string key, string value)
        {
            var selectedProducts = new List<Product>();

            if (key == "Name")
            {
                selectedProducts = products.Where(it => it.Name.ToLower().Contains(value.ToLower())).ToList();
            }
            else if (key == "SerialNumber")
            {
                selectedProducts = products.Where(it => it.SerialNumber.ToLower().Contains(value.ToLower())).ToList();
            }
            else if (key == "UnitPrice")
            {
                selectedProducts = products.Where(it => it.UnitPrice.ToString().Contains(value.ToLower())).ToList();
            }
            else{
                selectedProducts = products.ToList();
            }

            return selectedProducts;
        }

        [HttpPost]
        public ActionResult<Product> AddProduct([FromBody]Product model)
        {
            products.Add(model);
            return model;
        }
    }
}
