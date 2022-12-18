using CA3_X00180961.Controllers;
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
        Mock<IShopRepo> _shopRepo = new Mock<IShopRepo>();

        [TestMethod]
        public void GetAllItemsTest()
        {
            var expected = new List<ItemModel>(1)
            {
                new ItemModel() {ItemId= 1, ItemName = "ItemName", ItemType = "ItemType"}
             };


            
            _shopRepo.Setup(x => x.GetItemModels()).Returns(() => expected);
            var controller = new ItemsController(_shopRepo.Object);
         
            //ACT
            var response = controller.GetItemModel();
          

            Assert.AreEqual(expected.GetType(), response.GetType());
           
            
        }

        [TestMethod]
        public void GetReturnsNotFound()
        {
            // Arrange
            var controller = new ItemsController(_shopRepo.Object);

            // Act
            //IHttpActionResult actionResult = controller.Delete(10);

            // Assert
            //Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }
    }
}