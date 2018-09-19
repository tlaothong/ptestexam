using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Somsor.Q4.Pos.Api.Models;

namespace Somsor.Q4.Pos.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PosController : ControllerBase
    {
        public static List<Order> Orders = new List<Order>();

        [HttpGet]
        public ActionResult<IEnumerable<Order>> List()
        {
            return Orders;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> Get(string id)
        {
            return Orders.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Create([FromBody]Order request)
        {
            request.Id = Guid.NewGuid().ToString();
            request.PurchaseDate = DateTime.Now;
            request.Products = request.Products.Where(x => x.PurchaseCount > 0).ToList();
            request.TotalPrice = request.Products.Sum(x => x.PurchaseCount * x.UnitPrice);
            Orders.Add(request);
        }

        [HttpPost("{id}")]
        public void Delete(string id)
        {
            Orders = Orders.Where(x => x.Id != id).ToList();
        }

        [HttpGet]
        public void UseMockProducts()
        {
            //Orders = new List<Product>{
            //    new Product{
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "LG TV",
            //        SerialNumber = "LG1234",
            //        UnitPrice = 15900,
            //    },
            //    new Product{
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "iPhone Z",
            //        SerialNumber = "PZ3452",
            //        UnitPrice = 39990,
            //    },
            //    new Product{
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "mi Pro 5",
            //        SerialNumber = "PRO258",
            //        UnitPrice = 6900,
            //    },
            //    new Product{
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "V9",
            //        SerialNumber = "V93654",
            //        UnitPrice = 9999,
            //    },
            //};
        }

        [HttpGet]
        public void Reset()
        {
            Orders = new List<Order>();
        }
    }
}
