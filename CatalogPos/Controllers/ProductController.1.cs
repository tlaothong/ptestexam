using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogPos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogPos.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {    
        private static List<Products> products=new List<Products>  
        {
            new Products {name="commedy",id="1",price="250"},
            new Products {name="herror",id="2",price="150"},
            new Products {name="romance",id="3",price="299"}
        };      
        [HttpGet]
        public List<Products> GetAllproduct()
        {
            return products;
        }
        [HttpPost]
        public string CreateProduct([FromBody]Products data)
        {
            products.Add(data);
            return data.name;
        }
    }
}
