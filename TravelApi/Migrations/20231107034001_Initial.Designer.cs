﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20231107034001_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            City = "Purple",
                            Country = "Guyana",
                            Description = "So fun wow",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 2,
                            City = "Montreal",
                            Country = "Canada",
                            Description = "Bad place",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 3,
                            City = "Hyderabad",
                            Country = "India",
                            Description = "Meow",
                            Rating = 4
                        },
                        new
                        {
                            ReviewId = 4,
                            City = "Bile",
                            Country = "Barf",
                            Description = ".....",
                            Rating = 1
                        },
                        new
                        {
                            ReviewId = 5,
                            City = "Kingston",
                            Country = "Jamaica",
                            Description = "Sweet",
                            Rating = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
