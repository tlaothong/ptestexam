using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bmiapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace bmiapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BMIController : ControllerBase
    {
        [HttpGet]
        public BMIResponse Get(int weight, int height)
        {
            const int MinimumWeight = 1;
            const int MaximumHeight = 1;
            var areArgumentsValid = weight >= MinimumWeight && height >= MaximumHeight;
            if (!areArgumentsValid) return null;

            var response = new BMIResponse();
            response.BMI = Math.Round((weight / Math.Pow(height, 2)) * 703, 1);

            const double Minimum = 18.5;
            const double Maximum = 25;
            if (response.BMI < Minimum) response.Message = "You're underweight. You should consult your doctor!";
            else if (response.BMI > Maximum) response.Message = "You're overweight. You should consult your doctor!";
            else response.Message = "You're within the normal weight range.";

            return response;
        }
    }
}
