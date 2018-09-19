using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApi.Model;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class QuestionIV : Controller
    {
        MongoClient db;
        IMongoCollection<Insertitem> Collection;

        public void QuestionIVController()
        {            
            db = new MongoDB.Driver.MongoClient("mongodb://admin:admin1234@ds161092.mlab.com:61092/ptest");
            var test = db.GetDatabase("ptest");
            Collection = test.GetCollection<Insertitem>("insertitem");
            //ItemCollection = test.GetCollection<Insertitem>("insertitem");
        }

        // GET api/values
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }
        // GET api/values
        [HttpGet]
        public IEnumerable<Insertitem> GetItem()
        {
            var data = Collection.Find(x => true).ToList();
            return data;
        }

        [HttpPost]
        public bool Post([FromBody]Insertitem model)
        {
            model.Id = Guid.NewGuid().ToString();

            Collection.InsertOne(model);
            return true;

        }


    }
}
