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
            new Products {name="commedy",id="1",price=250,item=10},
            new Products {name="herror",id="2",price=150,item=10},
            new Products {name="romance",id="3",price=299,item=10}
        }; 
        [HttpGet("{name}/{item}/{price}")]
        public string Get(string name,int item,int price)
        {
            var result = item*price;
            return "totalamount : " + result  + "baht";
        }     
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
