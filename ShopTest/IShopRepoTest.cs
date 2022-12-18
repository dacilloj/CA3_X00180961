using CA3_X00180961.Controllers;
using CA3_X00180961.ShopRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Moq;
using ServiceStack;
using ShopRepository;
using ShopRepository.Repository;
using System.Web.Http;

namespace ShopTest
{
    [TestClass]
    public class IShopRepoTest
    {
        public static object GetMock()
        {
            var mock =  new Mock<IShopRepo>();
            mock.Setup(m => m.GetItemModels()).Returns(() => new Mock<IEnumerable<ItemModel>>().Object);
            
            return mock;
        }


        [TestMethod]
        public void TestRepo()
        {
           var repoMock = GetMock();
            Assert.IsNotNull(repoMock);


        }


        private List<ItemModel> GetTestItems()
        {
            var testProducts = new List<ItemModel>();
            testProducts.Add(new ItemModel { ItemId = 1, ItemName = "Demo1", ItemType = "Type1" });
            testProducts.Add(new ItemModel { ItemId = 2, ItemName = "Demo2", ItemType = "Type2" });
            testProducts.Add(new ItemModel { ItemId = 3, ItemName = "Demo3", ItemType = "Type3" });
            testProducts.Add(new ItemModel { ItemId = 4, ItemName = "Demo4", ItemType = "Type4" });

            return testProducts;
        }
    }

}
