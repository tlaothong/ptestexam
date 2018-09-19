using System.Collections.Generic;

namespace storewebapi.Models
{
    public class CreateNewPurchaseOrderRequest
    {
        public IEnumerable<PurchaseOrderInfo> Orders { get; set; }
    }

}