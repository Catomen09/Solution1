﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(CapstoneContext))]
    [Migration("20240418190044_add_mig_CompanieInfos")]
    partial class add_mig_CompanieInfos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Entities.CompaniesInfo", b =>
                {
                    b.Property<int>("CompanieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanieId"), 1L, 1);

                    b.Property<string>("CompanieStockCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EnergyUsage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MenEmployees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RenewableEnergy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Scope1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Scope2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Scope3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalEmployees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WaterUsage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WomenEmployees")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CompanieId");

                    b.ToTable("CompanieInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
