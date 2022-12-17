using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class ProductFromShopAModel
    {
        [Required]
        [Key]
        [JsonIgnore]
        public int ProductId { get; set; }

        [Required]
        public double ProductPrice { get; set; }

        [ForeignKey("ShopID")]
        [JsonIgnore]
        //foreign relationships
        public int ShopID { get; set; } = 1;

        [ForeignKey("ItemModel")]
        public int? ItemID { get; set; }

        
        //may not need the below
        public ItemModel Item { get; set; } = default!;

        
        public ShopModel Shop { get; set; } = default!;


    }
}
