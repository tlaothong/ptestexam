using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;


namespace webapi.Controllers
{
    [Route("api/[controller]/[Action]/")]
    [ApiController]
    public class CalController : ControllerBase
    {

        [HttpGet("{weight}/{height}")]
        public ActionResult<string> CalculatorBMI(double weight,double height)
        {
            var cal = new CalBmi();
            var bmi = cal.Calculator(weight,height);
             string bmifinal = bmi.ToString("#,###.0");
            return bmifinal ;
            
        }

    }
}
