using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Persistence
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }    
    }
}
