using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int Price { get; set; }
    }
}
