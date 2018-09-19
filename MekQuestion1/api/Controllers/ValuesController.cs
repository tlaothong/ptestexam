using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]/[action]/")]
    [ApiController]
    public class ValuesController : Controller
    {

        // GET api/values/60/180
        [HttpGet("{weight}/{height}")]
        public double Bmirun(double weight, double height)
        {
            var result = (weight/(height*height))*10000;
            return result;
        }

    }
}
