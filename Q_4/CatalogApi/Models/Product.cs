using System;

namespace CatalogApi.Models
{
    public class Product
    {
        public string serial_number { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        // public bool Ischecked { get; set; }
    }
}