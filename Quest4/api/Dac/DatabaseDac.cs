using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Authentication;
using api.Models;
using MongoDB.Driver;

namespace api.Dac
{
    public class DatabaseDac
    {
        IMongoCollection<Item> ItemCollection { get; set; }
        IMongoCollection<CartItem> CartItemCollection { get; set; }
        public DatabaseDac()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://user:Passw0rd@ds161312.mlab.com:61312/exam"));
            settings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = SslProtocols.Tls12
            };
            var mongoClient = new MongoClient(settings);
            var database = mongoClient.GetDatabase("exam");
            ItemCollection = database.GetCollection<Item>("Item");
            CartItemCollection = database.GetCollection<CartItem>("CartItem");
        }

        public void CreateNewItem(Item document)
        {
            ItemCollection.InsertOne(document);
        }

        public List<Item> ItemList(Expression<Func<Item, bool>> expression)
        {
            return ItemCollection.Find(expression).ToList();
        }

        public List<CartItem> CartItemList(Expression<Func<CartItem, bool>> expression)
        {
            return CartItemCollection.Find(expression).ToList();
        }

        public void Create(CartItem document)
        {
            CartItemCollection.InsertOne(document);
        }
    
        public void Update(CartItem document)
        {
            CartItemCollection.ReplaceOne(it => it._id == document._id, document);
        }

        public void Remove(CartItem document)
        {
            CartItemCollection.DeleteOne(it => it._id == document._id);
        }
    }
}