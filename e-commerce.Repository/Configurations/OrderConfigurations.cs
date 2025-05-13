using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities.OrderAggregations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_commerce.Repository.Configurations
{
    public class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Order & OrderItems Relationship
            builder.HasMany(order => order.OrderItems)
                   .WithOne(item => item.Order)
                   .HasForeignKey(item => item.OrderId);

            // because address and shipping address will be in the same entity
            builder.OwnsOne(order => order.ShippingAddress, address => address.WithOwner());

            // Conversion of OrderStatus
            builder.Property(order => order.Status)
                   .HasConversion(status => status.ToString(),
                                  status => (OrderStatus)Enum.Parse(typeof(OrderStatus), status));
        }
    }
}
