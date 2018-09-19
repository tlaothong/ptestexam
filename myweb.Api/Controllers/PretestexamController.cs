using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myweb.Api.Models;
namespace myweb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PretestexamController : ControllerBase
    {

        [HttpGet("[action]/{weight}/{height}")]
        public double QuestionI(double weight, double height)
        {
            var call = new CheckQuestion();
            return call.QuestionI(weight, height);
        }

        [HttpGet("[action]/{number}")]
        public string QuestionII(int number)
        {
            var call = new CheckQuestion();
            return call.QuestionII(number);
        }


        [HttpGet("[action]")]
        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product{Id = "001",ProductName="LG TV",SerialNumber="LG1234",ProductPrice=15900},
                new Product{Id = "002",ProductName="iPhone Z",SerialNumber="PZ3452",ProductPrice=39900},
                new Product{Id = "003",ProductName="Macbook Pro",SerialNumber="KV1584",ProductPrice=25000},
                new Product{Id = "004",ProductName="IPod touch",SerialNumber="LD1664",ProductPrice=35000},
            };
            return products;
        }


    }
}
