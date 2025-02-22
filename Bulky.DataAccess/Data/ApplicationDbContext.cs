using Bulky.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Title1",
                    Description = "Description1",
                    ISBN = "isbn1",
                    Author = "Author1",
                    ListPrice = 50,
                    Price = 10,
                    Price50 = 50,
                    Price100 = 100,
                    CategoryId = 0,
                    ImageURL = ""
                });
        }


    }
}
