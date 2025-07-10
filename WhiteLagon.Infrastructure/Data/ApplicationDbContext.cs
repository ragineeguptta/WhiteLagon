using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagon.Domain.Entities; // Ensure this namespace matches your entity classes

namespace WhiteLagon.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; } // Replace 'YourEntity' with your actual entity class  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(new Villa
                {
                    Id = 1,
                    Name = "Villa 1",
                    Description = "Description for Villa 1",
                    Price =1000,
                    ImageUrl = "https://example.com/villa1.jpg",
                    Sqft = 500,
                    Occupency = 2
                },
                new Villa
                {
                    Id = 2,
                    Name = "Villa 2",
                    Description = "Description for Villa 2",
                    Price =1200,
                    ImageUrl = "https://example.com/villa2.jpg",
                    Sqft = 700,
                    Occupency = 4
                },
                new Villa
                {
                    Id = 3,
                    Name = "Villa 3",
                    Description = "Description for Villa 3",
                    Price = 2000,
                    ImageUrl = "https://example.com/villa3.jpg",
                    Sqft = 900,
                    Occupency = 6
                },
                new Villa
                {
                    Id = 4,
                    Name = "Villa 4",
                    Description = "Description for Villa 4",
                    Price = 900,
                    ImageUrl = "https://example.com/villa4.jpg",
                    Sqft = 1100,
                    Occupency = 8
                }
            );
        }
    }
}
