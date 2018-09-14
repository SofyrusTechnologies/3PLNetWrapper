using _3PL.Net.Model;
using _3PL.Net.Services.Customers.Items;
using _3PL.Net.Services.Inventory;
using System;
using Xunit;

namespace _3PL.Net.Tests
{
    public class StockServiceTests : IClassFixture<CustomerTestsFixture>
    {
        CustomerTestsFixture _customerTestFixture;
        public StockServiceTests(CustomerTestsFixture customerTestsFixture)
        {
            _customerTestFixture = customerTestsFixture;
        }
        [Fact]
        public void GetItemStockSummaryTest()
        {

            var expected = new StockService().GetItemStockSummary(14550, _customerTestFixture.AccessToken);
            Assert.NotNull(expected);
            Assert.True(expected.summaries[0].onHand > 0);


        }

        [Fact]
        public void GetStockTest()
        {
            var expected = new StockService().GetStock(_customerTestFixture.CustomerId,_customerTestFixture.FacilityId, _customerTestFixture.AccessToken);
            Assert.NotNull(expected);
            Assert.True(expected.TotalResults > 0);
        }

        [Fact]
        public void GetStockByDateTest()
        {
            var expected = new StockService().GetStockByDate(_customerTestFixture.CustomerId, _customerTestFixture.FacilityId, DateTime.Now, _customerTestFixture.AccessToken);
            Assert.NotNull(expected);
            Assert.True(expected.TotalResults > 0);


        }

    }
}

