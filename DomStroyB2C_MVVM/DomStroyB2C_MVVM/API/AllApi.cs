using DomStroyB2C_MVVM.ViewModels;

namespace DomStroyB2C_MVVM.API
{
    class AllApi
    {
        public static readonly string BASE_URL = "http://143.244.156.131/api/v1";

        public static readonly string AUTH_TOKEN = $"token {MainWindowViewModel.user_token}";

        public static readonly string CLIENT = BASE_URL + "/client/";

        public static readonly string INVOICE_SENDED = BASE_URL + "/invoice/?status=send";

        public static readonly string SHOP = BASE_URL + "/shop/";
    }
}
