using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellerWebMvc.Models;
using SellerWebMvc.Models.ViewModels;

namespace SellerWebMvc.Data
{
    public class SellerWebMvcContext : DbContext
    {
        public SellerWebMvcContext (DbContextOptions<SellerWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
