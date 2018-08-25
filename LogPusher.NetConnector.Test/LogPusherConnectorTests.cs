using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogPusher.NetConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using LogPusher.NetConnector;

namespace LogPusher.NetConnector.Tests
{


}

namespace LogPusher.NetConnector.Test
{
    [TestClass()]
    public class LogPusherConnectorTests
    {
        private AuthModel _authModel = new AuthModel();
        private const string email = "your log pusher email";
        private const string password = "your md5 password";
        private const string appId = "your app key get from logpusher control panel";

        public LogPusherConnectorTests()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");

            this._authModel = new AuthModel()
            {
                ApiKey = appId,
                Password = password,
                UserName = email

            };
        }




        [TestMethod]
        public void GetLatestLog()
        {


        }


        [TestMethod]
        public async Task SendLogAsync()
        {

        PushModel model = new PushModel
            {
                AuthModel = _authModel,
                LogModel = new LogModel
                {
                    UserName = email,
                    Category = "Apple Test",
                    EventId = Guid.NewGuid().ToString(),
                    LogMessage = "You can use html tag inside LogMessage. Please not use html, body or any head tag we can insert automatically for you :)",
                    LogTime = DateTime.Now.ToShortTimeString(),
                    LogTypes = LogPusher.NetConnector.Enums.LogType.Information,
                    ShortDescription = "Apple application test new logpusher client. Please see the detail.",
                    Source = "LogPusherConnector",
                    Subject = "A new Connector Test"
                }
            };

            ///    var returend = model.SendLog();

            //Exception ex = null;
            //System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
            var returned = await model.SendLog();

        }

        [TestMethod()]
        public void GetLogDetailTest()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void PostSearchKeyTest()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void PostOrderDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTotalCommissionData()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostLoginUser()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void PostProductAddToCart()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void PostProductDeleteToCart()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void GetTurtaWeather()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTurtaWeather()
        {
            Assert.Fail();
        }
    }
}