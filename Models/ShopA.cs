using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class ShopA
    {
       
        [Key]
        [JsonIgnore]
        public int ProductId { get; set; }

        [Required]
        public double ProductPrice { get; set; }

      
        [JsonIgnore]
        //foreign relationships
        public int? ShopID { get; set; } = 1;

        
        public int? ItemID { get; set; }


        //Model Navigaiton propert
        //may not need the below
        [JsonIgnore]
        public ItemModel? Item { get; set; }

        [JsonInclude]
        public ShopModel? Shop { get; set; }


    }
}
