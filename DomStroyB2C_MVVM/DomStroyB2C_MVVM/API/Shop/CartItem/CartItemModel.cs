using System.Collections.Generic;

namespace DomStroyB2C_MVVM.API.Shop.CartItem
{
    public class CartItemModel
    {
        public int cart { get; set; }
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public int product { get; set; }
        public double amount { get; set; }
    }
}
