using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Shop.CartItem
{
    class CartItemWithExpireDateModel
    {
        public int cart { get; set; }
        public List<ItemExpireDate> items { get; set; }
    }

    public class ItemExpireDate
    {
        public int product { get; set; }
        public double amount { get; set; }
        public string expire_date { get; set; }
    }
}
