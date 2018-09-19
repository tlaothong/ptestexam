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

        [HttpGet("{id}")]
        public Product GetProduct(string id)
        {
            var isValid = !string.IsNullOrWhiteSpace(id);
            if (isValid) return null;
            return _myProducts.FirstOrDefault(it => it.Id == id);
        }

        // [HttpPost]
        // public bool RegisterProduct([FromBody]Product model)
        // {
        //     var isValid =
        //     model != null &&
        //     !string.IsNullOrWhiteSpace(model.Name);
        //     if (!isValid) return false;

        //     model.Id = Guid.NewGuid().ToString();
        //     _myProducts.Add(model);
        //     return true;
        // }
    }
}
