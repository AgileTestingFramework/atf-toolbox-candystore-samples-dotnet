using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Xml;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.Script.Services;

using System.Collections;
using System.Collections.Generic;

namespace CandyStoreAutomation.Tests.Webservice
{
    [TestClass]
    public class OrderRESTTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("MyGetOrderDataSource")]
        public void WebSvcShouldGetOrderById()
        {
            //Get method
            using (var httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(TestContext.DataRow["WebService URL"].ToString()+TestContext.DataRow["OrderID"].ToString());
                string finalResult = response.Result;
                XmlDocument doc = JsonConvert.DeserializeXmlNode(finalResult, "Root");
                XmlNodeList candies = doc.GetElementsByTagName("candy");

                Convert.ToDecimal(doc.SelectSingleNode("Root/orderTotal").InnerText).ShouldBeEquivalentTo(Convert.ToDecimal(TestContext.DataRow["OrderTotal"]), "We expected the order total.");
                candies.Count.ShouldBeEquivalentTo(Convert.ToInt32(TestContext.DataRow["CandyCount"]), "We expected the candy count.");
            }
        }

        [TestMethod]
        [DataSource("MyCreateSimpleOrderDataSource")]
        public void WebSvcShouldCreateSimpleOrder()
        {
            //Post method

            // Create the Json parameters (Can also be done from poco
            List<object> orderLines = new List<object>();
            orderLines.Add(new { sku = TestContext.DataRow["sku"].ToString(), quantity = Convert.ToInt32(TestContext.DataRow["quantity"]) });

            // Setup the request
            WebRequest req = WebRequest.Create(TestContext.DataRow["WebService URL"].ToString());

            req.Method = "POST";
            req.ContentType = "text/json";

            using (var streamWriter = new StreamWriter(req.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    orderLines
                });

                streamWriter.Write(json);
            }

            // Call the service
            var httpResponse = (HttpWebResponse)req.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var finalResult = streamReader.ReadToEnd();
                XmlDocument doc = JsonConvert.DeserializeXmlNode(finalResult, "Root");

                // Assert the Order Total is as expected
                doc.SelectSingleNode("Root/orderTotal").InnerText.Should().Contain(".6");
            }
        }
    }



}
