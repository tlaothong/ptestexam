using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bmicalculator.Models;
using Microsoft.AspNetCore.Mvc;


namespace bmicalculator.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        
        [HttpGet("{weight}/{height}")]
        public BMIClass Calculate(double weight,double height)
        {
            double maxAvg = 25;
            double minAvg = 18.5; 
            double mybmi = Math.Ceiling((weight/Math.Pow((height/100),2) )* 100) / 100;            
            BMIClass result = new BMIClass();            
            result.Bmi = mybmi;
            if (mybmi>=minAvg&&mybmi<=maxAvg) result.Message = "You're within the normal weight range";
            else if (mybmi<minAvg) result.Message = "You're underweight. You should consult your doctor!";
            else result.Message = "You're overweight. You should consult your doctor!";
            return result;
        }
    }
    
}
