namespace LogPusher.NetConnector
{
    public class AuthModel
    {

        /// <summary>
        ///  LogPusher Username ( Email)
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// LogPusher Password (MD5)
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// LogPusher Application Key ( Please get a new key for new app Control Panel)
        /// </summary>
        public string ApiKey { get; set; }

        public string AuthToken { get; set; }
    }
}
