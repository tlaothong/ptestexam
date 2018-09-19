using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalogapi.Models
{
    public class Catalog
    {
        public string _id { get; set; }
        public string Name {get; set;}
        public string Serial {get; set;}
        public double Price {get; set;}
    }
}
