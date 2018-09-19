using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bmiapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bnicalculate : ControllerBase
    {
        [HttpGet]
        public double Get(double weight, double height)
        {
            var a = new calculatelogic();
            var result = a.bmi(weight,height);
              return result;
        }
    }
}
