﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhiteLagon.Infrastructure.Data;

#nullable disable

namespace WhiteLagon.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250710155401_adddata4")]
    partial class adddata4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WhiteLagon.Domain.Entities.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupency")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9806),
                            Description = "Description for Villa 1",
                            ImageUrl = "https://example.com/villa1.jpg",
                            Name = "Villa 1",
                            Occupency = 2,
                            Price = 1000,
                            Sqft = 500,
                            Updated_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9809)
                        },
                        new
                        {
                            Id = 2,
                            Created_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9818),
                            Description = "Description for Villa 2",
                            ImageUrl = "https://example.com/villa2.jpg",
                            Name = "Villa 2",
                            Occupency = 4,
                            Price = 1200,
                            Sqft = 700,
                            Updated_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9819)
                        },
                        new
                        {
                            Id = 3,
                            Created_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9821),
                            Description = "Description for Villa 3",
                            ImageUrl = "https://example.com/villa3.jpg",
                            Name = "Villa 3",
                            Occupency = 6,
                            Price = 2000,
                            Sqft = 900,
                            Updated_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9821)
                        },
                        new
                        {
                            Id = 4,
                            Created_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9823),
                            Description = "Description for Villa 4",
                            ImageUrl = "https://example.com/villa4.jpg",
                            Name = "Villa 4",
                            Occupency = 8,
                            Price = 900,
                            Sqft = 1100,
                            Updated_At = new DateTime(2025, 7, 10, 15, 54, 1, 298, DateTimeKind.Utc).AddTicks(9823)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
