using Microsoft.EntityFrameworkCore;
using BulkyBook.Models;
using System.ComponentModel.DataAnnotations;
namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        //creating Categories table

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //inserting initial data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", DisplayOrder = 0 },
                new Category { CategoryId = 2, Name = "Romance", DisplayOrder = 1 },
                new Category { CategoryId = 3, Name = "Comedy", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title = "How to Make Money", Author = "Jagadeesh Gongidi", Description = "This book describes about how to make money", ISBN = "46g34b", ListPrice = 199, Price = 150, Price50 = 100, Price100 = 50 ,CategoryId=1},
                new Product { Id = 2, Title = "How to Make Friends", Author = "Jagadeesh Gongidi", Description = "This book describes about how to make friend ships that losts a decade", ISBN = "46g34b", ListPrice = 400, Price = 300, Price50 = 200, Price100 = 100,CategoryId=2 });
        }
    }
}

