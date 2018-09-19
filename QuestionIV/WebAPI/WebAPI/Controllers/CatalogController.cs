using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/[controller]")]

    public class CatalogController : Controller
    {
        IMongoCollection<Item> Item { get; set; }

        public CatalogController()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://krit_NA:thegigclubna2522@ds125322.mlab.com:25322/kritna"));
            settings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = SslProtocols.Tls12
            };
            var mongoClient = new MongoClient(settings);
            var database = mongoClient.GetDatabase("kritna");
            Item = database.GetCollection<Item>("Catalog_Item");
        }

        [HttpGet("[action]")]
        public IEnumerable<Item> ListItems()
        {
            var items = Item.Find(x => true).ToList();
            return items;
        }

        [HttpGet("[action]/{id}")]
        public Item GetItem(string id)
        {
            var item = Item.Find(x => x.Id == id).FirstOrDefault();
            return item;
        }

        [HttpPost("[action]")]
        public void CreateItem([FromBody]Item item)
        {
            item.Id = Guid.NewGuid().ToString();
            Item.InsertOne(item);
        }

        [HttpPost("[action]")]
        public void EditItem([FromBody]Item item)
        {
            var _item = GetItem(item.Id);
            Item.ReplaceOne(x => x.Id == item.Id, item);
        }

        [HttpPost("[action]/{id}")]
        public void DeleteItem(string id)
        {
            Item.DeleteOne(x => x.Id == id);
        }
    }
}