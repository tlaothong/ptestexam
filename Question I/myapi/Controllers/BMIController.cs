using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BMIController : ControllerBase
    {
        // GET api/values
        [HttpGet("{weight}/{height}")]
        public ActionResult<IEnumerable<string>> GetBMI(double weight, double height)
        {
            
            var engine = new BMIEngine();
            return new string[] { engine.GetBMI(weight, height) };
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "ddd" };
        }
    }

    public class BMIEngine
    {
        public string GetBMI(double weight, double height)
        {
            var resutl = "You're within the normal weight range.";
            var bmi = (weight/( Math.Pow(height, 2))) * 703;
            if (bmi >= 18.5 && bmi <= 25) {
                resutl = "Your BMI : " + bmi.ToString("0.0");
            }
            return resutl;
        }
    }
}
