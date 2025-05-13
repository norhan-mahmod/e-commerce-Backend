using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_commerce.Repository.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Product & ProductImages Relationship
            builder.HasMany(product => product.ProductImages)
                   .WithOne(image => image.Product)
                   .HasForeignKey(image => image.ProductId);

            // Product & Brand Relationship
            builder.HasOne(product => product.Brand)
                   .WithMany(brand => brand.Products)
                   .HasForeignKey(product => product.BrandId);

            // Product & Categories Relationship
            builder.HasOne(product => product.Category)
                   .WithMany(category => category.Products)
                   .HasForeignKey(product => product.CategoryId);

        }
    }
}
