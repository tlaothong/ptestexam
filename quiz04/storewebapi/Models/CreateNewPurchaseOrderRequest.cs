using System.Collections.Generic;

namespace storewebapi.Models
{
    public class CreateNewPurchaseOrderRequest
    {
        public PurchaseOrderInfo[] Orders { get; set; }
    }

}