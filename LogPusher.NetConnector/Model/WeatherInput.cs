using System;

namespace LogPusher.NetConnector
{
    public class WeatherInput
    {
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal Pressure { get; set; }
        public decimal Altitude { get; set; }
        public DateTime CreateDate { get; set; }
   
        }

}

