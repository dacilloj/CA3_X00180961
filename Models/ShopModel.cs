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

        public ICollection<ProductModel> Products { get; set; } = default!;
    }
}
