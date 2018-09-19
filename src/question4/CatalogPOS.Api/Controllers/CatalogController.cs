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
        IEnumerable<Product> products = new List<Product>()
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

            return selectedProducts;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
