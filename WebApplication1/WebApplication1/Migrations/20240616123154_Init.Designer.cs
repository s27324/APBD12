﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Entities;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240616123154_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Entities.Employee", b =>
                {
                    b.Property<int>("IdEmp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmp"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEmp")
                        .HasName("Employee_pk");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            IdEmp = 1,
                            Address = "adres1",
                            Email = "alot@gmail.com",
                            FirstName = "Kacper",
                            LastName = "Alot"
                        },
                        new
                        {
                            IdEmp = 2,
                            Address = "adres2",
                            Email = "andrzejdariuszowski@gmail.com",
                            FirstName = "Dariusz",
                            LastName = "Andrzejewski"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
