using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BmiApi.Models;

namespace BmiApi.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/[controller]/[action]/")]
    public class BmiController : Controller
    {
        [HttpGet("{weight}/{height}")]
        public BmiModel calculateBMI(double weight, double height)
        {
            BmiModel bmiModel = new BmiModel();

            // var bmi_value = (weight / (Math.Pow(height*0.01, 2)) )* 703;
             var bmi_value = (weight / (Math.Pow(height*0.01, 2)) );
            bmiModel.bmi = bmi_value;
            bmiModel.weight = weight;
            bmiModel.height = height;
            if (bmiModel.bmi >= 18.5 && bmiModel.bmi <= 25)
            {
                bmiModel.bmiStatus = "You're within the normal weight range.";
            }
            else if (bmiModel.bmi < 18.5)
            {
                bmiModel.bmiStatus = "You're underweight. You should consult your doctor!";
            }
            else
            {
                bmiModel.bmiStatus = "You're overweight. You should consult your doctor!";
            }

            return bmiModel;
        }

    }
}
