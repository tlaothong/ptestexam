using System.Collections.Generic;

namespace web.Models
{
    public class Cart
    {
        public List<CartItem> items {get; set;}
        public double totalprice {get; set;}
    }

    public class CartItem : Item
    {
        public int amount {get;set;}
    }
}