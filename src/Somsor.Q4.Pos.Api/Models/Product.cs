using System;

namespace Somsor.Q4.Pos.Api.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public double UnitPrice { get; set; }
    }
}