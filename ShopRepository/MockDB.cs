using Models;
using ShopRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRepository
{
    public class MockDB 
    {
        IEnumerable<ProductFromShopAModel> MockShopA = new List<ProductFromShopAModel> 
        {
            new ProductFromShopAModel{ ProductId = 1, ItemID = 1, ProductPrice = 999, ShopID = 1 },
            new ProductFromShopAModel{ ProductId = 2, ItemID = 2, ProductPrice = 2000, ShopID = 1},
            new ProductFromShopAModel{ ProductId = 3, ItemID = 3, ProductPrice = 200, ShopID =  1},
        };

        IEnumerable<ProductFromShopBModel> MockShopB = new List<ProductFromShopBModel>
        {
            new ProductFromShopBModel{ ProductId = 1, ItemID = 1, ProductPrice = 800, ShopID = 2 },
            new ProductFromShopBModel{ ProductId = 2, ItemID = 2, ProductPrice = 2500, ShopID = 2},
            new ProductFromShopBModel{ ProductId = 3, ItemID = 3, ProductPrice = 250, ShopID = 2 },
        };

        IEnumerable<ItemModel> Items = new List<ItemModel>
        {
            new ItemModel{ ItemId = 1, ItemName = "IPhone 10", ItemType = "Phone" },
            new ItemModel{ ItemId = 2, ItemName = "MacBook Air", ItemType = "Laptop"},
            new ItemModel{ ItemId = 3, ItemName = "AirPods", ItemType = "Earphones"}
        };

        IEnumerable<ShopModel> Shops = new List<ShopModel>
        {
            new ShopModel{ ShopId = 1, ShopName = "Currys"},
            new ShopModel{ ShopId = 2, ShopName = "DID"},
       
        };

        public IEnumerable<ItemModel> GetItemModels()
        {
            throw new NotImplementedException();
        }
    }
}
