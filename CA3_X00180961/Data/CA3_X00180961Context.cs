using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace CA3_X00180961.Data
{
    public class CA3_X00180961Context : DbContext
    {
        public CA3_X00180961Context (DbContextOptions<CA3_X00180961Context> options)
            : base(options)
        {
        }

        public DbSet<Models.ProductModel> ProductModel { get; set; } = default!;
    }
}
