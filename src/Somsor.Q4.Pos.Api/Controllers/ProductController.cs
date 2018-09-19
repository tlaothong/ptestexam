﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Somsor.Q4.Pos.Api.Models;

namespace Somsor.Q4.Pos.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> Products = new List<Product>();

        [HttpGet]
        public ActionResult<IEnumerable<Product>> List()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(string id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Create([FromBody] Product request)
        {
            request.Id = Guid.NewGuid().ToString();
            Products.Add(request);
        }

        [HttpPost("{id}")]
        public void Edit(string id, [FromBody]Product request)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
            product.Name = request.Name;
            product.SerialNumber = request.SerialNumber;
            product.UnitPrice = request.UnitPrice;
        }

        [HttpPost("{id}")]
        public void Delete(string id)
        {
            Products = Products.Where(x => x.Id != id).ToList();
        }

        [HttpGet]
        public void UseMockProducts()
        {
            Products = new List<Product>{
                new Product{
                    Id = Guid.NewGuid().ToString(),
                    Name = "LG TV",
                    SerialNumber = "LG1234",
                    UnitPrice = 15900,
                },
                new Product{
                    Id = Guid.NewGuid().ToString(),
                    Name = "iPhone Z",
                    SerialNumber = "PZ3452",
                    UnitPrice = 39990,
                },
                new Product{
                    Id = Guid.NewGuid().ToString(),
                    Name = "mi Pro 5",
                    SerialNumber = "PRO258",
                    UnitPrice = 6900,
                },
                new Product{
                    Id = Guid.NewGuid().ToString(),
                    Name = "V9",
                    SerialNumber = "V93654",
                    UnitPrice = 9999,
                },
            };
        }

        [HttpGet]
        public void Reset()
        {
            Products = new List<Product>();
        }
    }
}
