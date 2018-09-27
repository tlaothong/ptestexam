using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptestapi.Model;

namespace ptestapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionIVController : ControllerBase
    {
        public static List<Product> storeProducts = new List<Product>();
        public static Order userOrder = new Order();

        public QuestionIVController()
        {

        }

        [HttpGet("")]
        public List<Product> GetStoreProducts()
        {
            return storeProducts;
        }

        [HttpGet("")]
        public Order GetOrder()
        {
            return userOrder;
        }

        [HttpGet("")]
        public Order AddOrder(string serialNumber)
        {
            var product = storeProducts.Where(x => x.SerialNumber == serialNumber).FirstOrDefault();
            userOrder.Orders.Add(product);
            userOrder.TotalPrice = userOrder.Orders.Sum(x => x.UnitPrice);
            return userOrder;
        }

        [HttpPost("")]
        public List<Product> AddProduct([FromBody]Product newProduct)
        {
            storeProducts.Add(newProduct);

            return storeProducts;
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public double UnitPrice { get; set; }
    }


    public class Order
    {
        public List<Product> Orders = new List<Product>();
        public double TotalPrice { get; set; }
    }
}