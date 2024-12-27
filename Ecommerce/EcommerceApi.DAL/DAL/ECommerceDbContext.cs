using EcommerceApi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.DAL.DAL;

public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions opt) : base(opt) { }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
