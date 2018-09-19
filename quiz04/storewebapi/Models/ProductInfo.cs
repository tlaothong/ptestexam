using System.Collections.Generic;

namespace storewebapi.Models
{
    public class ProductInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IList<TagInfo> CustomTags { get; set; }
    }
}