using CA3_X00180961.ShopRepository;
using Models;
using ShopRepository.Repository;

namespace ShopRepository
{
    public class RealDb : IShopRepo
    {
        CA3_X00180961Context _db;

        public RealDb(CA3_X00180961Context db)
        {
            _db = db;
        }

        public IEnumerable<ItemModel> GetItemModels()
        {
            throw new NotImplementedException();
        }
    }
}