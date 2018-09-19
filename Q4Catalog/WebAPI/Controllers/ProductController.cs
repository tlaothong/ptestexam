using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Product> Collection;
        
        public ProductController()
        {
            _client = new MongoClient("mongodb://admin:lljick146@ds056559.mlab.com:56559/votemeifyoucan");
            _database = _client.GetDatabase("votemeifyoucan");
            Collection = _database.GetCollection<Product>("Product");
        }

        [HttpGet]
        public IEnumerable<Product> ListProduct()
        {
            var result = Collection.Find(std => true).ToList();
            return result;
        }
        
        [HttpPost]
        public void AddProduct([FromBody]Product request)
        {
            request._id = Guid.NewGuid().ToString();
            Collection.InsertOne(request);
        }
    }
    
    public class Product
    {
        [BsonId]
        public string _id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public double UnitPrice { get; set; }
    }
}

