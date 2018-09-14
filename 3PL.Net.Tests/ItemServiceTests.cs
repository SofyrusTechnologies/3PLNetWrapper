using _3PL.Net.Model;
using _3PL.Net.Services.Customers.Items;
using Xunit;

namespace _3PL.Net.Tests
{
    public class ItemServiceTests : IClassFixture<CustomerTestsFixture>
    {
        CustomerTestsFixture _customerTestFixture;
        public ItemServiceTests(CustomerTestsFixture customerTestsFixture)
        {
            _customerTestFixture = customerTestsFixture;
        }
        [Fact]
        public void SaveItemTest()
        {

            Item item = new Item
            {
                Description = "Item From Test C#",
                Description2 = "Item Second Description C#",
                Sku = System.Guid.NewGuid().ToString(),
                Upc = string.Empty,
                Options = new Options
                {
                    InventoryUnit = new Inventoryunit
                    {
                        UnitIdentifier = new UnitIdentifier { Name = "EACH" }
                    },
                    PackageUnit = new PackageUnit
                    {
                        UnitIdentifier = new UnitIdentifier { Name = "CARTON" },
                        Imperial = new Imperial { Length = 1.0F, Width = 2.0F, Height = 3.0F, Weight = 130F },
                        InventoryUnitsPerUnit = 1.0F
                    }
                }

            };

            ItemsService itemsService = new ItemsService();

            var expected = itemsService.SaveItem(item, _customerTestFixture.CustomerId, _customerTestFixture.AccessToken);

            Assert.NotNull(expected);
            Assert.True(expected.ItemId > 0);


        }

        [Fact]
        public void GetItemListTest()
        {
            ItemsService itemsService = new ItemsService();

            var expected = itemsService.GetList(new GetItemListCriteria(), _customerTestFixture.CustomerId, _customerTestFixture.AccessToken);

            Assert.True(expected.TotalResults > 0);
        }

        [Fact]
        public void DeleteItemTest()
        {
            ItemsService itemsService = new ItemsService();

            itemsService.Delete(14682, _customerTestFixture.CustomerId, _customerTestFixture.AccessToken);


        }

    }
}

