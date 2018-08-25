namespace LogPusher.NetConnector
{
    public class WeatherModel
    {

        /// <summary>
        /// LogPusher Auht Model for registred app and user
        /// </summary>
        public AuthModel AuthModel { get; set; }
        public string Token { get; set; }
        public string AuthKey { get; set; }
        public WeatherInput  WeatherInput { get; set; }

    }

}

