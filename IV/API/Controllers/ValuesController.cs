using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using api2.Models;

namespace api2.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        IMongoCollection<Dog> DogCallection;
        public ValuesController()
        {
            var client = new MongoDB.Driver.MongoClient("mongodb://Sorry:ritg0hkot@ds157742.mlab.com:57742/sorryder");
            var db = client.GetDatabase("sorryder");
            DogCallection = db.GetCollection<Dog>("Dog");
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Dog> GetAllDog()
        {
            return DogCallection.Find(x => true).ToList();
        }

        // GET api/values/5
        // [HttpGet("{Name}")]
        // public Dog GetByName(String Name)
        // {
        //     return DogCallection.Find(x => x.Name == Name).FirstOrDefault();
        // }

        // POST api/values
        // [HttpPost("{data}")]
        // public void InsertNewDog([FromBody]Dog data)
        // {
        //     data.Id = Guid.NewGuid().ToString();
        //     DogCallection.InsertOne(data);
        // }

        [HttpPost]
        public void create([FromBody]Dog request)
        {

            request.Id = Guid.NewGuid().ToString();
            request.Name = request.Name;
            request.Serial = request.Serial;
            request.price = request.price;

            DogCallection.InsertOne(request);
        }
        // [HttpPost("{request}")]
        // public void EditDog([FromBody]Dog request)
        // {
        //     DogCallection.ReplaceOne(x => x.Id == request.Id, request);
        // }

    }
}