using EFCore_Cascading_Dropdown.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Cascading_Dropdown.DBContext
{
    public class InMemoryDBContext : DbContext
    {
        public InMemoryDBContext(DbContextOptions<InMemoryDBContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(a => a.Category).HasForeignKey(a => a.CategoryId);
            
            modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
