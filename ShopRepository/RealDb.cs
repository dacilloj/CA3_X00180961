using CA3_X00180961.ShopRepository;

namespace ShopRepository
{
    public class ReadDb : IShopRepo
    {
        CA3_X00180961Context db = default!;

        public ReadDb()
        {

        }
    }
}