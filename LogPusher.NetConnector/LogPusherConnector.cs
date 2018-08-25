using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace LogPusher.NetConnector
{
    public static class LogPusherConnector

    {



        #region + + + FOR GENERAL & DEVELOPER PACKAGES + + + 

        /// <summary>
        /// This Method quickly send exception inner message to LogPusher
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public async static Task<string> SendLog(this PushModel model, Exception ex)
        {
            object requestData = new
            {

                AuthKey = model.AuthModel.GetAuthKey(),
                ApiKey = model.AuthModel.ApiKey,
                LogMessage = model.LogModel.LogMessage + " EX : " + JsonConvert.SerializeObject(ex),
                Source = ex.Source,
                Category = model.LogModel.Category,
                LogType = model.LogModel.LogTypes,
                LogTime = DateTime.Now.ToShortTimeString(),
                CreateDate = DateTime.Now,
                EventId = model.LogModel.EventId,
                Subject = model.LogModel.Subject,
                ShortDescription = model.LogModel.ShortDescription
            };


            var jsonData = JsonConvert.SerializeObject(requestData);
            return await jsonData.SendRequest(EndPoint.POST_LOG);

        }


        public async static Task<string> GetLatestLogs(this object model)
        {

            var jsonData = JsonConvert.SerializeObject(model);
            return await jsonData.SendRequest(EndPoint.GET_LATEST_LOGS);
        }
        
        /// <summary>
        /// Send log basically send LogPusher Log Model. 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async static Task<string> SendLog(this PushModel model)
        {
            object requestData = new
            {
                AuthKey = model.AuthModel.GetAuthKey(),
                ApiKey = model.AuthModel.ApiKey,
                LogMessage = model.LogModel.LogMessage,
                Source = model.LogModel.Source,
                Category = model.LogModel.Category,
                LogType = model.LogModel.LogTypes,
                LogTime = DateTime.Now.ToShortTimeString(),
                CreateDate = DateTime.Now,
                EventId = model.LogModel.EventId,
                Subject = model.LogModel.Subject,
                ShortDescription = model.LogModel.ShortDescription
            };

            var jsonData = JsonConvert.SerializeObject(requestData);
           var x = await jsonData.SendRequest(EndPoint.POST_LOG);
            return x;
        }

        /// <summary>
        /// 
        /// </summary>
        public async static Task<string> GetLatestLog(GetLatestLogRequest request)
        {
            dynamic requestData = new object();

            requestData.AuthKey = request.AuthKey;
            requestData.RegistrationKey = request.RegistrationKey;
            requestData.UserId = request.UserId;

            var jsonData = JsonConvert.SerializeObject(requestData);
            return await jsonData.SendRequest(EndPoint.GET_LATEST_LOGS);

        }

        /// <summary>
        /// 
        /// </summary>
        public async static Task<string> GetLogDetail(int logId)
        {

            dynamic requestData = new object();

            requestData.id = logId;

            var jsonData = JsonConvert.SerializeObject(requestData);
            return await jsonData.SendRequest(EndPoint.GET_LOG_DETAIL);

        }

        #endregion


        #region + + + FOR E-COMMERCE PACKAGES + + + 

        /// <summary>
        /// 
        /// </summary>
        public static void PostSearchKey()
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void PostOrderData()
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GetTotalCommissionData()
        {

            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        public static void PostLoginUser()
        {

            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        public static void PostProductAddToCart()
        {

            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        public static void PostProductDeleteToCart()
        {

            throw new NotImplementedException();
        }


        #endregion

        #region + + + FOR IoT PACKAGES + + + 

        /// <summary>
        /// 
        /// 
        /// </summary>
        public async static Task<string> GetTurtaWeather(this WeatherModel model)
        {

            var jsonData = JsonConvert.SerializeObject(model);
            return await jsonData.SendRequest(EndPoint.POST_LOG);

        }

        /// <summary>
        /// 
        /// </summary>
        public static void PostTurtaWeather()
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
