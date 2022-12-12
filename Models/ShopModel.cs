using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ShopModel
    {
        [Required]
        [Key]
        public int ShopId { get; set; }

        [Required]
        public string ShopName { get; set; } = "";

        //foreign attributes. Don't think I need this
        //[InverseProperty("ProductFromShopAModel")]
        public virtual ProductFromShopAModel? ProductsA { get; set; }

        // [InverseProperty("ProductFromShopBModel")]
        public virtual  ProductFromShopBModel? ProductsB { get; set; }
    }
}
