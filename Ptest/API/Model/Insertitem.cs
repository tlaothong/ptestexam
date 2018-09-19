using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Insertitem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
    }

}
