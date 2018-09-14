using _3PL.Net.Model;
using _3PL.Net.Services.Customers.Items;
using _3PL.Net.Services.Orders;
using System;
using Xunit;

namespace _3PL.Net.Tests
{
    public class OrderServiceTests : IClassFixture<CustomerTestsFixture>
    {
        CustomerTestsFixture _customerTestFixture;
        public OrderServiceTests(CustomerTestsFixture customerTestsFixture)
        {
            _customerTestFixture = customerTestsFixture;
        }
        [Fact]
        public void CreateOrderTest()
        {
            Order order = new Order
            {
                CustomerIdentifier = new Customeridentifier { Id = _customerTestFixture.CustomerId.ToString() },
                FacilityIdentifier = new Facilityidentifier { Id = _customerTestFixture.FacilityId.ToString() },
                ReferenceNum = Guid.NewGuid().ToString(),
                BillingCode = "Prepaid",
                RoutingInfo = new Routinginfo { Carrier = "UPS", Mode = "Ground", Account = "1234567", ShipPointZip = "90033" },
                ShipTo = new Shipto { CompanyName = "Test", Name = "Test", Address1 = "Test", City = "Los Angeles", State = "CA", Zip = "90505", Country = "US" },
                Items = new OrderItems
                {
                    Httpapi3plCentralcomrelsordersitem = new[] {
                    new HttpApi3PlcentralComRelsOrdersItem {ItemIdentifier=new Itemidentifier{Sku="3018TEST" },Qty=1.0F }
                }
                }
            };

            OrdersService ordersService = new OrdersService();
            var expected = ordersService.CreateOrder(order, _customerTestFixture.AccessToken);

            Assert.NotNull(expected);
            Assert.True(expected.readOnly.orderId>0);

        }

        [Fact]
        public void GetOrderDetails()
        {
            var expected = new OrdersService().GetOrderDetails(42996, _customerTestFixture.AccessToken);
            Assert.NotNull(expected);
            Assert.True(expected.readOnly.orderId > 0);
        }

        [Fact]
        public void CancelOrder()
        {
            OrderCancel cancel = new OrderCancel {
                orderIdentifiers = new Orderidentifier[] { new Orderidentifier { id = 42996 } },
                charge = 10,
                reason = "wrong product test",
                invoiceCreationInfo = new Invoicecreationinfo { setInvoiceDate = false, utcOffset = 4 }
            };
            new OrdersService().CancelOrder(cancel, _customerTestFixture.AccessToken);
        }

    }
}

