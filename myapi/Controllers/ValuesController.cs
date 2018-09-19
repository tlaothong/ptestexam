using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       [HttpGet("[action]/{height}/{weight}")]
       public double bmi(double height,double weight){
           return weight / (height / 100 * height / 100);
       }
       [HttpGet("[action]/{name}/{number}/{price}")]
       public string insert(string name,string number,string price){
           return name+number+price;
       }
    }
}
