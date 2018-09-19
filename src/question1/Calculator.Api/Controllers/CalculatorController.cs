using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/values
        [HttpGet("{weight}/{height}")]
        public ActionResult<CalculateResult> Get(double weight, double height)
        {
            var bmiCalculator = new BMICalculator();
            var result = bmiCalculator.Calculate(weight, height);
            return result;
        }
    }
}
