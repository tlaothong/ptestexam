using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bmicalculate.Models;
using Microsoft.AspNetCore.Mvc;

namespace bmicalculate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BmiCalController : ControllerBase
    {
        [HttpGet("{weight}/{hight}")]
        public bmiResult BMI(double weight, double hight)
        {
            var logic = new Logicbmi();
            var r = logic.BMI(weight, hight);

            var bmi = new bmiResult();
            bmi.Result = r;

            return bmi;
        }
    }
}
