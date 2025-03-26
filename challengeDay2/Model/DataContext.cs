using challengeDay2.Model.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace challengeDay2.Model;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });
            
        modelBuilder.Entity<Client>().Property(c => c.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Order>().Property(o => o.Id).ValueGeneratedOnAdd();
            
        modelBuilder.Entity<RefreshToken>().HasKey(rt => rt.Token);
        modelBuilder.Entity<RefreshToken>().HasIndex(rt => rt.Token).IsUnique();
    }
}