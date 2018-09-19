using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace bmicalculator.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        
        [HttpGet("{weight}/{height}")]
        public String Get(string weight,string height)        
        {
            return weight+height;
        }
        
        [HttpGet]
        public String Get()        
        {
            return "Hello";
        }
        
        [HttpGet("{weight}/{height}")]
        public string Calculate2(double weight,double height)
        {        
            return weight+height+"Hell";
        }

        [HttpGet("{weight}/{height}")]
        public double Calculate(double weight,double height)
        {
            double mybmi = (weight/Math.Pow(height,2))*703;;
            return mybmi;
        }
    }
    
}
