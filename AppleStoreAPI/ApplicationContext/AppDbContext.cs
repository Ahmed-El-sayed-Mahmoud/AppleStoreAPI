using AppleStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AppleStoreAPI.ApplicationContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
                        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);


            modelBuilder.Entity<ProductImage>()
                .HasOne(img=>img.product)
                .WithMany(p=>p.ProductImages)
                .HasForeignKey(img=>img.ProductId);


            modelBuilder.Entity<Product>()
                .HasMany(p => p.specifications)
                .WithMany();

        }
    }
}
