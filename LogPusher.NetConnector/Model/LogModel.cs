using System;
using LogPusher.NetConnector;
using LogPusher.NetConnector.Enums;

namespace LogPusher.NetConnector
{
    public class LogModel
    {
        public LogModel()
        {
            this.LogType = GetLogType(this.LogTypes);
        }

        private string GetLogType(LogType logTypes)
        {
            var _logTypeStr = string.Empty;

            switch (logTypes)
            {
                case Enums.LogType.Alert:
                    _logTypeStr = "Alert";
                    break;
                case Enums.LogType.Success:
                    _logTypeStr = "Success";
                    break;
                case Enums.LogType.Warning:
                    _logTypeStr = "Warning";
                    break;
                case Enums.LogType.Critical:
                    _logTypeStr = "Critical";
                    break;
                case Enums.LogType.Information:
                    _logTypeStr = "Information";
                    break;
                case Enums.LogType.Other:
                    _logTypeStr = "Other";
                    break;
                default:
                    _logTypeStr = "Not Set";
                    break;
            }

            return _logTypeStr;
        }


        /// <summary>
        /// Your Log Message Content
        /// </summary>
        public string LogMessage { get; set; }

        /// <summary>
        /// Your Log Source for exp : OpenCart , CMS or any program name
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        ///  Log Category for exp : Order , Member Register
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Log Type for exp : Alert , Critical, Information
        /// </summary>
        public LogType LogTypes{ get; set; }
        private string LogType { get; set; }
        /// <summary>
        ///  short log time for exp : 10:22 AM or 10:22 Will be use for advanced reports
        /// </summary>
        public string LogTime { get; set; }

        /// <summary>
        /// If you have a any event ID your software or device 
        /// </summary>
        public string EventId { get; set; }
        public string UserName { get; set; }

        /// <summary>
        /// Required filed for mobile application
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// For mobile application log list 
        /// required
        /// </summary>
        public string ShortDescription { get; set; }


    }
}


