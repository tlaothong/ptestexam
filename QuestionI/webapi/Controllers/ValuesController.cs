using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{kg}/{cm}")]
        public double CalcBMI(double kg,double cm)
        {
            var calc = new calc();
            var weight = calc.changeWeight(kg);
            var height = calc.changeHeight(cm);
            var bmi = calc.calcBmi(weight,height);
            return bmi;
        }
    }

    public class calc
    {
        public double changeWeight(double kg)
        {
            var weight = kg * 2.2046;
            return weight;
        }

        public double changeHeight(double cm)
        {
            var height = cm * 0.39370;
            return height;
        }

        public double calcBmi(double weight, double height)
        {
            var bmi = weight / Math.Pow(height, 2) * 703;
            return bmi;
        }


    }
}