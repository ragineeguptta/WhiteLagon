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
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<Amenity> Amenities { get; set; }

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

            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                    Villa_Number = 101,
                    VillaId = 1,

                },
                new VillaNumber
                {
                    Villa_Number = 102,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 103,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 104,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 105,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 201,
                    VillaId = 2,

                },
                new VillaNumber
                {
                    Villa_Number = 202,
                    VillaId = 2,
                },
                new VillaNumber
                {
                    Villa_Number = 203,
                    VillaId = 2,
                },
                new VillaNumber
                {
                    Villa_Number = 301,
                    VillaId = 3,

                },
                new VillaNumber
                {
                    Villa_Number = 302,
                    VillaId = 3,
                },
                new VillaNumber
                {
                    Villa_Number = 303,
                    VillaId = 3,
                }
             );

            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    Id = 1,
                    VillaId = 1,
                    Name = "Amenity 1"
                },
                new Amenity
                {
                    Id = 2,
                    VillaId = 2,
                    Name = "Amenity 2"
                },
                new Amenity
                {
                    Id = 3,
                    VillaId = 1,
                    Name = "Amenity 3"
                },
                new Amenity
                {
                    Id = 4,
                    VillaId = 4,
                    Name = "Amenity 4"
                },
                new Amenity
                {
                    Id = 5,
                    VillaId = 4,
                    Name = "Amenity 5"
                },
                new Amenity
                {
                    Id = 6,
                    VillaId = 2,
                    Name = "Amenity 6"
                }
            );
        }
    }
}
