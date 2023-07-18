using Katmanli.Core;
using Katmanli.Repository.Configiration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<Category> Categories {get; set;}

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfigiration());
            modelBuilder.ApplyConfiguration(new CategoryConfigiration());
            modelBuilder.ApplyConfiguration(new ProductFeatureConfigiration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
