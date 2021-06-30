﻿// <auto-generated />
using System;
using Filmkolik.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Filmkolik.Data.Migrations
{
    [DbContext(typeof(EFProjectContext))]
    partial class EFProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Filmkolik.Entities.Entity.FilmDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.Property<string>("Not")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("FilmDetails");
                });

            modelBuilder.Entity("Filmkolik.Entities.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<string>("RolString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2021, 7, 1, 0, 50, 38, 430, DateTimeKind.Local).AddTicks(111),
                            FirstName = "admin",
                            LastName = "user",
                            Password = "admin",
                            Rol = 1,
                            RolString = "Admin_Role",
                            Username = "admin"
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2021, 7, 1, 0, 50, 38, 430, DateTimeKind.Local).AddTicks(7667),
                            FirstName = "film",
                            Password = "user",
                            Rol = 3,
                            RolString = "FilmUser_Role",
                            Username = "film"
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2021, 7, 1, 0, 50, 38, 430, DateTimeKind.Local).AddTicks(7678),
                            FirstName = "film",
                            Password = "user",
                            Rol = 2,
                            RolString = "StarUser_Role",
                            Username = "star"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
