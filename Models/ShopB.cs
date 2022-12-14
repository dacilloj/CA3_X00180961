using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class ShopB
    {
       
        [Key]
        
        public int ProductId { get; set; }

        [Required]
        public double ProductPrice { get; set; }

        //foreign relationships
        [JsonIgnore]
        public int? ShopID { get; set; } = 2;

        
        public int? ItemID { get; set; }

        [JsonIgnore]
        //may not need the below
        public ItemModel? Item { get; set; }

        [JsonIgnore]
        public ShopModel? Shop { get; set; } 

    }
}
