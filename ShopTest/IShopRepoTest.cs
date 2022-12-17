using CA3_X00180961.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Moq;
using ServiceStack;
using ShopRepository;
using ShopRepository.Repository;

namespace ShopTest
{
    [TestClass]
    public class IShopRepoTest
    {

        [TestMethod]
        public void GetAllItemsTest()
        {
            var expected = new List<ItemModel>(1)
            {
                new ItemModel() {ItemId= 1, ItemName = "ItemName", ItemType = "ItemType"}
             };


            Mock<IShopRepo> _shopRepo = new Mock<IShopRepo>();
            _shopRepo.Setup(x => x.GetItemModels()).Returns(() => expected);
            var controller = new ItemModelsController(_shopRepo.Object);
         
            //ACT
            var response = controller.GetItemModel();
          

            Assert.AreEqual(expected.GetType(), response.GetType());
           
            
        }
    }
}