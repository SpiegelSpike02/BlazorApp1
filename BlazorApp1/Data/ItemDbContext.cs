using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public class ItemDbContext(DbContextOptions<ItemDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Record> Records { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().Property(i => i.Number).HasComputedColumnSql("dbo.CalculateNumberFunction([ProductCode])");
    }
}


