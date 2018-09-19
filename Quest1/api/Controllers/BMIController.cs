using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BMIController : ControllerBase
    {
        // GET api/values
        [HttpGet("{weight}/{height}")]
        public string Calculator(double weight, double height)
        {
            var bmiAction = new BMI();

            var bmi = bmiAction.Calculator(weight,height);
            var message = bmiAction.BMIMessage(bmi);
            return message;
   
        }
    }

    public class BMI
    {
       public double Calculator(double weight, double height)
        {
            var bmi = (weight/(Math.Pow(height,2)))*703;
            return Math.Round(bmi, 2);
   
        }

        public string BMIMessage(double bmi)
        {
            var message = bmi >= 18.5 && bmi <= 25 ? $"Your BMI: {bmi}/nYou're within the normal weight range."
            : bmi < 18.5 ? "You're underweight. You should consult your doctor!"
            : "You're overweight. You should consult your doctor!";
            return message;
        }
    }
}
