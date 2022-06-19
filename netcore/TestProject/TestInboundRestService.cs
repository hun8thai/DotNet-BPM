using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class TestInboundRestService
    {
        [TestInitialize]
        public void SetupSwiperTests()
        {
        }


        [TestMethod]
        //[DataRow("a", "b")]
        //[DataRow(" ", "a")]
        public void TestPingService()
        {
            var options = new RestClientOptions("https://localhost:44313")
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);
            var request = new RestRequest().AddQueryParameter("msg", "Hungtq");
            request.Resource = "/Ping";
            var response = client.Get<string>(request);
            Assert.IsNotNull(response);
        }

        [TestCleanup]
        public void CleanupSwiperTests()
        {
            try
            {
            }
            catch (Exception)
            {
            }
        }
    }
}
