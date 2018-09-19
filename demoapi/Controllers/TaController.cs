using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaController : ControllerBase
    {
        
        [HttpGet("{weight}/{high}")]
        public double CheckBmiCalculator(double weight,double high)
        {
            var a = new CalculatorLogic();
            var result = a.Calculator(weight,high);
            return result;
         
        }
       
        
    }
} 