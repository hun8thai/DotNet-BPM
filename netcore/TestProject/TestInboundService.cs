using InboundService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ServiceModel;

namespace TestProject
{
    [TestClass]
    public class TestInboundService
    {
        private IPingServiceChannel _client;

        [TestInitialize]
        public void SetupSwiperTests()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:5050/Service.svc?wcdl");
            ChannelFactory<IPingServiceChannel> myChannelFactory = new ChannelFactory<IPingServiceChannel>(binding, address);

            // Create a channel.
            _client = myChannelFactory.CreateChannel();
        }

        [TestMethod]
        //[DataRow("a", "b")]
        //[DataRow(" ", "a")]
        public void TestPingService()
        {
            var result = _client.Ping("Hungtq");
            Assert.IsNotNull(result);
        }

        [TestCleanup]
        public void CleanupSwiperTests()
        {
            try
            {
                _client.Close();
                _client = null;
            }
            catch (Exception)
            {
            }
        }
    }
}
