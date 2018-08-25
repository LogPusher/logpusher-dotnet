using LogPusher.NetConnector;

namespace LogPusher.NetConnector
{
    public class PushModel
    {
        /// <summary>
        /// LogPusher Auht Model for registred app and user
        /// </summary>
        public AuthModel AuthModel { get; set; }

        /// <summary>
        /// Basic LogModel for sending Log Information to LogPusher
        /// </summary>
        public LogModel LogModel { get; set; }

    }


}

