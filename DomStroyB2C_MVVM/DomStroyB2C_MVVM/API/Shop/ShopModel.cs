using Newtonsoft.Json;
using System;

namespace DomStroyB2C_MVVM.API.Shop
{
    class ShopModel
    {
        [JsonProperty("cart_id")]
        public int _cart_id { get; set; }

        [JsonProperty("client")]
        public int _client { get; set; }

        [JsonProperty("traded_at")]
        public DateTime _traded_at { get; set; }

        [JsonProperty("card")]
        public double _card { get; set; }

        [JsonProperty("loan_sum")]
        public double _loan_sum { get; set; }

        [JsonProperty("cash_sum")]
        public double _cash_sum { get; set; }

        [JsonProperty("discount_sum")]
        public double _discount_sum { get; set; }

        [JsonProperty("loan_dollar")]
        public double _loan_dollar { get; set; }

        [JsonProperty("discount_dollar")]
        public double _discount_dollar { get; set; }

        [JsonProperty("transfer")]
        public double _transfer { get; set; }

        [JsonProperty("cash_dollar")]
        public double _cash_dollar { get; set; }
    }
}
