using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace webapi.Models
{
    public class Item
    {
        
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int TotalPrice  { get; set; }
        internal void InsertOne(Item item)
        {
            throw new NotImplementedException();
        }
    }
}