using EFCore_Cascading_Dropdown.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Cascading_Dropdown.DBContext
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Wear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Grunge Skater Jeans", Code = "AWMGSJ", Price = 68, IsAvailable = true },
                new Product { Id = 2, CategoryId = 1, Name = "Polo Shirt", Code = "AWMPS", Price = 35, IsAvailable = true },
                new Product { Id = 3, CategoryId = 1, Name = "Skater Graphic T-Shirt", Code = "AWMSGT", Price = 33, IsAvailable = true },
                new Product { Id = 4, CategoryId = 1, Name = "Slicker Jacket", Code = "AWMSJ", Price = 125, IsAvailable = true },
                new Product { Id = 5, CategoryId = 1, Name = "Thermal Fleece Jacket", Code = "AWMTFJ", Price = 60, IsAvailable = true },
                new Product { Id = 6, CategoryId = 1, Name = "Unisex Thermal Vest", Code = "AWMUTV", Price = 95, IsAvailable = true },
                new Product { Id = 7, CategoryId = 1, Name = "V-Neck Pullover", Code = "AWMVNP", Price = 65, IsAvailable = true },
                new Product { Id = 8, CategoryId = 1, Name = "V-Neck Sweater", Code = "AWMVNS", Price = 65, IsAvailable = true },
                new Product { Id = 9, CategoryId = 1, Name = "V-Neck T-Shirt", Code = "AWMVNT", Price = 17, IsAvailable = true },
                new Product { Id = 10, CategoryId = 2, Name = "Bamboo Thermal Ski Coat", Code = "AWWBTSC", Price = 99, IsAvailable = true },
                new Product { Id = 11, CategoryId = 2, Name = "Cross-Back Training Tank", Code = "AWWCTT", Price = 0, IsAvailable = false },
                new Product { Id = 12, CategoryId = 2, Name = "Grunge Skater Jeans", Code = "AWWGSJ", Price = 68, IsAvailable = true },
                new Product { Id = 13, CategoryId = 2, Name = "Slicker Jacket", Code = "AWWSJ", Price = 125, IsAvailable = true },
                new Product { Id = 14, CategoryId = 2, Name = "Stretchy Dance Pants", Code = "AWWSDP", Price = 55, IsAvailable = true },
                new Product { Id = 15, CategoryId = 2, Name = "Ultra-Soft Tank Top", Code = "AWWUTT", Price = 22, IsAvailable = true },
                new Product { Id = 16, CategoryId = 2, Name = "Unisex Thermal Vest", Code = "AWWUTV", Price = 95, IsAvailable = true },
                new Product { Id = 17, CategoryId = 2, Name = "V-Next T-Shirt", Code = "AWWVNT", Price = 17, IsAvailable = true },
                new Product { Id = 18, CategoryId = 3, Name = "Blueberry Mineral Water", Code = "MWB", Price = 2.8M, IsAvailable = true },
                new Product { Id = 19, CategoryId = 3, Name = "Lemon-Lime Mineral Water", Code = "MWLL", Price = 2.8M, IsAvailable = true },
                new Product { Id = 20, CategoryId = 3, Name = "Orange Mineral Water", Code = "MWO", Price = 2.8M, IsAvailable = true },
                new Product { Id = 21, CategoryId = 3, Name = "Peach Mineral Water", Code = "MWP", Price = 2.8M, IsAvailable = true },
                new Product { Id = 22, CategoryId = 3, Name = "Raspberry Mineral Water", Code = "MWR", Price = 2.8M, IsAvailable = true },
                new Product { Id = 23, CategoryId = 3, Name = "Strawberry Mineral Water", Code = "MWS", Price = 2.8M, IsAvailable = true },
                new Product { Id = 24, CategoryId = 4, Name = "In the Kitchen with H+ Sport", Code = "PITK", Price = 24.99M, IsAvailable = true },
                new Product { Id = 25, CategoryId = 5, Name = "Calcium 400 IU (150 tablets)", Code = "SC400", Price = 9.99M, IsAvailable = true },
                new Product { Id = 26, CategoryId = 5, Name = "Flaxseed Oil 100 mg (90 capsules)", Code = "SFO100", Price = 12.49M, IsAvailable = true },
                new Product { Id = 27, CategoryId = 5, Name = "Iron 65 mg (150 caplets)", Code = "SI65", Price = 13.99M, IsAvailable = true },
                new Product { Id = 28, CategoryId = 5, Name = "Magnesium 250 mg (100 tablets)", Code = "SM250", Price = 12.49M, IsAvailable = true },
                new Product { Id = 29, CategoryId = 5, Name = "Multi-Vitamin (90 capsules)", Code = "SMV", Price = 9.99M, IsAvailable = true },
                new Product { Id = 30, CategoryId = 5, Name = "Vitamin A 10,000 IU (125 caplets)", Code = "SVA", Price = 11.99M, IsAvailable = true },
                new Product { Id = 31, CategoryId = 5, Name = "Vitamin B-Complex (100 caplets)", Code = "SVB", Price = 12.99M, IsAvailable = true },
                new Product { Id = 32, CategoryId = 5, Name = "Vitamin C 1000 mg (100 tablets)", Code = "SVC", Price = 9.99M, IsAvailable = true },
                new Product { Id = 33, CategoryId = 5, Name = "Vitamin D3 1000 IU (100 tablets)", Code = "SVD3", Price = 12.49M, IsAvailable = true });

        }
    }
}
