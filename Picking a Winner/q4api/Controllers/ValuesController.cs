using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoapi.Controllers; 

namespace q4api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public item GetItem()
        {
            return new item
            {
                name= "LG TV",
                serialnumber= "LG1234",
                unitprice = 15900
            };

             return new item
            {
                name= "iPhone Z",
                serialnumber= "PZ3452",
                unitprice = 39990
            };


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }





        // POST api/values
        [HttpPost]
        public void Createitem([FromBody]item data)
        {
            
        }






        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
