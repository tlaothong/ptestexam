using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values/
        [HttpGet("{name}/{id}")]
        public int Randomnumber(string name, int id)
        {
            List<User> player = new List<User> ();
            player.Add(new User{ name = name, number = id });

            return 0;
        }

    }

    public class User
    {
        public string name {get; set;}
        public int number {get; set;}
    }
}
