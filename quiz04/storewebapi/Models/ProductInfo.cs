namespace storewebapi.Models
{
    public class ProductInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public System.Collections.Generic.IDictionary<string, string> CustomTags { get; set; }
    }
}