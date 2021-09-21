using DomStroyB2C_MVVM.ViewModels;

namespace DomStroyB2C_MVVM.API
{
    class AllApi
    {
        public static readonly string BASE_URL = "http://143.244.156.131/api/v1";

        public static readonly string AUTH_TOKEN = $"token {MainWindowViewModel.user_token}";

        public static readonly string CLIENT = BASE_URL + "/client/";

        public static readonly string INVOICE_SENDED = BASE_URL + "/invoice/?status=send&limit=100";

        public static readonly string SHOP = BASE_URL + "/shop/";

        public static readonly string INVOICEITEM_SENDED = BASE_URL + "/invoice/";

        public static readonly string CART = BASE_URL + "/cart/";
        
        public static readonly string CARTITEM = BASE_URL + "/cart-item/";

        public static readonly string PRODUCT = BASE_URL + "/product/branch_product/";

        public static readonly string MINIMAL = BASE_URL + "/minimal/";

        public static readonly string BRANCH = BASE_URL + "/branch/";

        public static readonly string DEBTOR = BASE_URL + "/client/status/";

        public static readonly string CLIENT_HISTORY = BASE_URL + "/client/history/";

        public static readonly string CLIENT_LOAN_PAYMENT = BASE_URL + "/client-loan-payment/";

        public static readonly string ACCEPT_INVOCE = BASE_URL + "/invoice​/accept_invoice​/";
    }
}
