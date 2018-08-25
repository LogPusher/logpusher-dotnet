namespace LogPusher.NetConnector
{
    public static class EndPoint
    {

        // Version is a API version now is v1 currently online if you are set the blank v1 using default.
        public const string VERSION = "v2";

        // Base API Address 
        public const string BASE_ULR = "https://api.logpusher.com/";

        // Developer & General EndPoisnt 

        public const string POST_LOG = BASE_ULR + "api/agent/savelog";
        //todo: 
        public const string GET_LATEST_LOGS = BASE_ULR + "api/agent/getLatestLogs";

        /// ToDo: 
        public const string GET_LOG_DETAIL = BASE_ULR + "";


        // TurtaIot EndPoints 
        public const string POST_TURTA_WEATHER = BASE_ULR + "api/turtaIot/postWeatherData";
        //todo: 
        public const string GET_TURTA_WEATHER_DATA = BASE_ULR + "";


        // E-Commerce EndPoints
        /// ToDo: 
        public const string POST_SEARCH_KEY = BASE_ULR + "";
        /// ToDo: 
        public const string POST_ORDER_DATA = BASE_ULR + "";

        /// ToDo: 
        public const string GET_TOTAL_COMMISSION_DATA = BASE_ULR + "";

        /// <summary>
        /// The user is invited to add a basket of any product on the site.
        /// </summary>
        public const string POST_CART_ITEM_ADDED = BASE_ULR + "";
        /// <summary>
        /// The user is invited to delete a basket of any product on the site.
        /// </summary>
        public const string POST_CART_ITEM_DELETED = BASE_ULR + "";
        /// <summary>
        /// When new user register on your web site .
        /// </summary>
        public const string POST_ECOMMERCE_NEW_USER_REGISTER = BASE_ULR + "";

        /// <summary>
        /// we can report who is login your site and which time.
        /// </summary>
        public const string POST_ECOMMERCE_USER_LOGIN = BASE_ULR + "";



    }
}
