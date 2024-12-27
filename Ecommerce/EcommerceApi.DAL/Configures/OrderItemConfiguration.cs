using EcommerceApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceApi.DAL.Configures
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
