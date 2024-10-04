using iPhoneStoreWebAppMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace iPhoneStoreWebAppMVC.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Product>().HasKey(p => p.IDProduct);

        modelBuilder.Entity<Category>().HasKey(c => c.IDCategory);
    }
}
