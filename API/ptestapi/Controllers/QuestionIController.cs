using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptestapi.Model;

namespace ptestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionIController : ControllerBase
    {
        // GET api/values
        [HttpGet("{weight}/{height}")]
        public BMIResponse Get(double weight, double height)
        {
            var cal = new Q1();
            return cal.BmiCal(weight, height); ;
        }

    }
}