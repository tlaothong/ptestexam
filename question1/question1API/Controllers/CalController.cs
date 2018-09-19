using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using question1API.Models;

namespace question1API.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/[controller]/[Action]/")]
    public class CalController : Controller
    {
        [HttpGet("{weight}/{height}")]
        public value calculate(double weight, double height)
        {
            double sum;
            value keep = new value();
            sum = weight/(Math.Pow(height/100, 2));
            keep.bmi = sum;
            keep.weight = weight;
            keep.height = height;

            if (keep.bmi >= 18.5 && keep.bmi <= 25)
            {
                keep.comment = "You're underweight. You should consult your doctor!";
            }
            else
            {
                keep.comment = "You're within the normal weight range.";
            }
            return keep;


        }
    }
}
