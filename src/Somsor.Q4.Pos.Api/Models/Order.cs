using System;
using System.Collections.Generic;

namespace Somsor.Q4.Pos.Api.Models
{
    public class Order
    {
        public string Id { get; set; }
        public double TotalPrice { get; set; }
        public IEnumerable<ProductPurchase> Products { get; set; }
    }
}