using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellerWebMvc.Models.ViewModels;

namespace SellerWebMvc.Data
{
    public class SellerWebMvcContext : DbContext
    {
        public SellerWebMvcContext (DbContextOptions<SellerWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SellerWebMvc.Models.ViewModels.Department> Department { get; set; }
    }
}
