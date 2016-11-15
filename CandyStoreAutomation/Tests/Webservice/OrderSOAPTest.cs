using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using CandyStoreAutomation.CandyStore_OrderCandyService;

namespace CandyStoreAutomation.Tests.Webservice
{
    /// <summary>
    /// OrderSOAPTest
    /// 1. Add a Service Reference to your project http://localhost:8080/CandyStore/services/candyStoreOrderSOAP?wsdl
    /// 2. Select the service(s) you want to test
    /// 3. The service client classes will be added to a Service References folder within your project
    /// 4. Use the client classes generated to test your service
    /// 
    /// Note: App.config has changed\added this section system.serviceModel, these can be broken out into individual files for maintainability
    /// Endpoint address can be changed depending on the environment you want to test
    /// </summary>
    [TestClass]
    public class OrderSOAPTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void WebSvcShouldOrderCandyServiceBeAvailable()
        {
            using (var svc = new CandyStore_OrderCandyService.CandyOrderSOAPServiceClient("CandyOrderSOAPServicePort"))
            {
                Assert.IsTrue(svc.State == System.ServiceModel.CommunicationState.Created);
            }
        }

        [TestMethod]
        public void WebSvcShouldCandyOrderTotalBe()
        {
            using (var svc = new CandyOrderSOAPServiceClient("CandyOrderSOAPServicePort"))
            {
                var createOrderSvc = (CandyOrderSOAPService)svc;

                orderLinePogo orderline1 = new orderLinePogo();
                orderline1.sku = "000000001";
                orderline1.quantity = 1;

                orderLinePogo orderline2 = new orderLinePogo();
                orderline2.sku = "000000002";
                orderline2.quantity = 2;

                orderLinePogo[] order = new orderLinePogo[]{ orderline1, orderline2 };

                createCandyOrder1 createOrderRequest = new createCandyOrder1(order);

                createCandyOrderResponse1 response = createOrderSvc.createCandyOrder(createOrderRequest);

                response.orderResponse.orderTotal.Should().Be(new decimal(1.8), "we expected the order total calculated on the items ordered.");
            }
        }

        [TestMethod]
        [DataSource("MyCreateOrderDataSource")]
        public void WebSvcShouldCandyOrderTotalBeWithXMLDriver()
        {
            using (var svc = new CandyOrderSOAPServiceClient("CandyOrderSOAPServicePort"))
            {
                var createOrderSvc = (CandyOrderSOAPService)svc;
                List<orderLinePogo> orderLines = new List<orderLinePogo>();
                orderLinePogo orderline = null;

                foreach (DataRow orderLine in TestContext.DataRow.GetChildRows("order_orderline"))
                {
                    orderline = new orderLinePogo();
                    orderline.sku = orderLine["sku"].ToString();
                    orderline.quantity = Convert.ToInt32(orderLine["quantity"]);

                    orderLines.Add(orderline);
                }

                orderLinePogo[] order = orderLines.ToArray();

                createCandyOrder1 createOrderRequest = new createCandyOrder1(order);

                createCandyOrderResponse1 response = createOrderSvc.createCandyOrder(createOrderRequest);

                response.orderResponse.orderTotal.Should().Be(Convert.ToDecimal(TestContext.DataRow["ordertotal"]), "we expected the order total calculated on the items ordered.");
            }
        }
    }
}
