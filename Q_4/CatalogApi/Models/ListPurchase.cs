using System;
using System.Collections.Generic;

namespace CatalogApi.Models
{
    public class ListPurchase
    {
        public string id { get; set; }
         public List<Product> productList { get; set; }
    }
}