using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatalogApi.Models;

namespace CatalogApi.Controllers
{   
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/[controller]/[action]/")]
    public class ProductController : Controller
    {   
        private static IList<Product> products = new List<Product> {
            new Product{serial_number = "LG1234",name = "LG TV",amount= 0,price=300},
            new Product{serial_number = "LG5423",name = "iPhone Z",amount= 0,price=250},
            new Product{serial_number = "LG1653",name = "Laptop",amount= 0,price=150},
            new Product{serial_number = "LG1456",name = "Bag",amount= 0,price=160},
            new Product{serial_number = "LG5464",name = "Keyboard",amount= 0,price=450}
        };

        private static IList<ListPurchase> listPurchase = new List<ListPurchase> {
            
        };
        [HttpGet] 
        public IEnumerable<Product> GetAllProduct() {
            return products;
        }

        [HttpPost]
        public Product AddProduct([FromBody]Product newProduct) {
            products.Add(newProduct);
            return newProduct;
        }


        [HttpGet]
        public ListPurchase AddPurchase([FromBody]ListPurchase productPurchase) {
            productPurchase.id = Guid.NewGuid().ToString();
            return productPurchase;
        }

        // [HttpPost("{am}")]
        // public IEnumerable<Product> GetPurchase(IEnumerable am) {
        //     products.amount = am;
        // }
    }
}
