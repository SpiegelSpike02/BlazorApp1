using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDetail> ProductDetails { get; set; }
    public DbSet<Costumer> Costumers { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Sale> Sales { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductDetail>()
        .Property(p => p.Number)
        .HasComputedColumnSql("dbo.CalculateInventory([Id])");
    }
}


