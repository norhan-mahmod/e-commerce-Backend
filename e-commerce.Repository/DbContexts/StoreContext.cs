using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;
using e_commerce.Core.Entities.OrderAggregations;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Repository.DbContexts
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<SharedEntity>();
            foreach(var entry in entries)
            {
                if(entry.State == EntityState.Added)
                    entry.Entity.CreatedAt = DateTime.UtcNow;

                if(entry.State == EntityState.Modified)
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                // CreatedBy && UpdatedBy Should be alse set but when Identity Done to take UserId from Claims
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
