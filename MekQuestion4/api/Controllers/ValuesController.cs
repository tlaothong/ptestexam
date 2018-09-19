using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        IMongoCollection<Catalog> Collection { get; set; }
        public ValuesController()
    {
      var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://admin:ab1234@ds115918.mlab.com:15918/catalog"));
      settings.SslSettings = new SslSettings()
      {
        EnabledSslProtocols = SslProtocols.Tls12
      };
      var mongoClient = new MongoClient(settings);
      var database = mongoClient.GetDatabase("borrowdb");
      Collection = database.GetCollection<Catalog>("catalog");

    }
 
        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Catalog>  addcatalog(int id)
        {
            return null;
        }

        [HttpGet("{id}")]
        public IEnumerable<Catalog>  compu(int id)
        {
            return null;
        }

    }

    public class Catalog
    {
        public string name;
        public string serialnumber;
        public int unitprice;
    }

}
