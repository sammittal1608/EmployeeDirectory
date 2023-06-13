﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230606111611_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.DBModels.DBDepartment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "d66a4cf6-6f30-451e-adab-0a6adcb55398",
                            Count = 0,
                            Name = "IT"
                        },
                        new
                        {
                            Id = "801d3461-ccf1-4cc7-aee3-0f261cfa6de1",
                            Count = 0,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = "0b91a979-1155-46dc-b71f-6d6d95999ef5",
                            Count = 0,
                            Name = "MD"
                        },
                        new
                        {
                            Id = "705f54e0-5062-41c2-a30d-88c396705f07",
                            Count = 0,
                            Name = "Sales"
                        });
                });

            modelBuilder.Entity("Models.DBModels.DBEmployee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("PreferredName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Models.DBModels.DBJobTitle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobTitles");

                    b.HasData(
                        new
                        {
                            Id = "76216765-8f2c-4e9d-8d38-1f7bd38064fd",
                            Count = 0,
                            Title = "SharePoint Practice Head"
                        },
                        new
                        {
                            Id = "cbbefda7-4b5a-4284-988b-e37365fbe71f",
                            Count = 0,
                            Title = ".Net Development Lead"
                        },
                        new
                        {
                            Id = "ffa3bb5b-7507-46e5-bc44-e3adc73fb008",
                            Count = 0,
                            Title = "Recruiting Expert"
                        },
                        new
                        {
                            Id = "0eded364-1bec-4d95-8e93-77c3ebf1f38a",
                            Count = 0,
                            Title = "BI Developer"
                        },
                        new
                        {
                            Id = "80329967-0488-4049-aa84-aa0a344f219f",
                            Count = 0,
                            Title = "Business Analyst"
                        });
                });

            modelBuilder.Entity("Models.DBModels.DBOffice", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = "2000fb72-fe0f-439f-8c87-2210063dde43",
                            Count = 0,
                            CountryName = "India"
                        },
                        new
                        {
                            Id = "3c73d466-84d3-4d36-933f-8ab2e2498b9f",
                            Count = 0,
                            CountryName = "Seattle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
