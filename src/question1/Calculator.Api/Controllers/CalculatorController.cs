using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<CalculateResult> Get()
        {
            var bmiCalculator = new BMICalculator();
            var result = bmiCalculator.Calculate(50, 40);
            return result;
        }
    }
}
