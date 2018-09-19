using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using MongoDB.Driver;
using System.Security.Authentication;

namespace webapi.Controllers
{

    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/[controller]/[action]")]
    public class StoreController : Controller
    {
        IMongoCollection<Item> Item { get; set; }

        public StoreController()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://woraput:Dd123456@ds261302.mlab.com:61302/store"));
            settings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = SslProtocols.Tls12
            };
            var mongoClient = new MongoClient(settings);
            var database = mongoClient.GetDatabase("store");
            Item = database.GetCollection<Item>("Item");
        }

        
        [HttpGet]
        public IEnumerable<Item> ListItem()
        {
            var items = Item.Find(x => true).ToList();
            return items;
        }


        [HttpPost]
        public void AddItem([FromBody]Item item)
        {

            item.Name = Guid.NewGuid().ToString();
            item.Id = Guid.NewGuid().ToString();
            item.Price = item.TotalPrice;
            item.InsertOne(item);

            
        }
    }

}
