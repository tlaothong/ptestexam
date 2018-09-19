using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapi_exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController
    {
        [HttpGet("[action]/{weight}/{height}")]
        public double calculatingbmi(double weight, double height)
        {
            double bmi = 0;
            bmi = (weight / (height * height)) * 703;
            string str = String.Format("{0:F1}", bmi);
            bmi = double.Parse(str);
            return bmi;
        }
    }
}
