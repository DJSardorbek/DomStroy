using Newtonsoft.Json;

namespace DomStroyB2C_MVVM.API.Client
{
    class ClientModel
    {
        [JsonProperty("branch")]
        public int _branch { get; set; }

        [JsonProperty("first_name")]
        public string _firstName { get; set; }

        [JsonProperty("last_name")]
        public string _lastName { get; set; }

        [JsonProperty("address")]
        public string _address { get; set; }

        [JsonProperty("phone_1")]
        public string _phone_1 { get; set; }

        [JsonProperty("phone_2")]
        public string _phone_2 { get; set; }

        [JsonProperty("return_date")]
        public string _returnDate { get; set; }

        [JsonProperty("birth_date")]
        public string _birthDay { get; set; }
    }
}
