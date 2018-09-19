using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catalogapi.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace catalogapi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        
        private const string ConnectionString = @"mongodb://admin:p123456@ds243812.mlab.com:43812/demo";
        private const string DatabaseName = @"demo";
        private const string CollectionCatalog = @"catalogs";

        private IMongoDatabase _database;
        private IMongoCollection<Catalog> _collectionCatalog;

   public CatalogController()
   {
       var client = new MongoClient(ConnectionString);
       _database =  client.GetDatabase(DatabaseName);
       _collectionCatalog = _database.GetCollection<Catalog>(CollectionCatalog);
   } 
    // GET api/student
        [HttpGet]
        public IEnumerable<Catalog> GetCatalogs()
        {
            return _collectionCatalog.Find(it => true).ToList();
        }
        public void PurchaseItem()
        {

        }

   [HttpPost]
        public void AddItem([FromBody]Catalog model)
        {
            _collectionCatalog.InsertOne(model);
        }
    }
}
