using RestSharp;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace LogPusher.NetConnector
{


    /// <summary>
    /// 
    /// </summary>
    public static class LogPusherConnectorHelper

    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        private static string Base64Encode(this string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string GetAuthKey(this AuthModel model)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");
            var authKey = model.UserName + "|" + model.Password + "|" + DateTime.Now;
            return authKey.Base64Encode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataModel"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public async static Task<string> SendRequest(this string dataModel, string endPoint)
        {
            var responseContent = string.Empty;

            try
            {
                var client = new RestClient(endPoint);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", dataModel, ParameterType.RequestBody);

                Task<IRestResponse> t = client.ExecuteTaskAsync(request);
                t.Wait();
                var response = await t;


                //IRestResponse response = (await client.Execute(request));
                switch (response.ResponseStatus)
                {
                    case ResponseStatus.None:
                        responseContent = "We are not read any responseble content from LogPusher. Please contact hello@logpusher.com";
                        break;
                    case ResponseStatus.Completed:
                        responseContent = response.Content;
                        break;
                    case ResponseStatus.Error:
                    case ResponseStatus.TimedOut:
                    case ResponseStatus.Aborted:
                        responseContent = response.ErrorMessage;
                        break;

                }

            }
            catch (Exception ex)
            {

                responseContent = ex.Message;
            }
           
            return responseContent;

        }
    }
}
