using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class QuestionIV : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
        
        
    }
     public class Additem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
    }
}
