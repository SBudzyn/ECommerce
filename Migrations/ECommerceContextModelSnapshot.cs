﻿// <auto-generated />
using System;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    partial class ECommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerce.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("ECommerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Photos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SeriaId")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("SeriaId");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ECommerce.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ECommerce.Models.Seria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Serias");
                });

            modelBuilder.Entity("ECommerce.Models.Domain.Fridge", b =>
                {
                    b.HasBaseType("ECommerce.Models.Product");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.ToTable("Products");

                    b.HasDiscriminator().HasValue("Fridge");
                });

            modelBuilder.Entity("ECommerce.Models.Domain.Headphones", b =>
                {
                    b.HasBaseType("ECommerce.Models.Product");

                    b.Property<int>("ConnectionType")
                        .HasColumnType("int");

                    b.Property<bool>("IsWaterProof")
                        .HasColumnType("bit");

                    b.ToTable("Products");

                    b.HasDiscriminator().HasValue("Headphones");
                });

            modelBuilder.Entity("ECommerce.Models.Domain.Tablet", b =>
                {
                    b.HasBaseType("ECommerce.Models.Product");

                    b.Property<double>("DisplaySize")
                        .HasColumnType("float");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.ToTable("Products", t =>
                        {
                            t.Property("DisplaySize")
                                .HasColumnName("Tablet_DisplaySize");

                            t.Property("Memory")
                                .HasColumnName("Tablet_Memory");
                        });

                    b.HasDiscriminator().HasValue("Tablet");
                });

            modelBuilder.Entity("ECommerce.Models.Domain.Television", b =>
                {
                    b.HasBaseType("ECommerce.Models.Product");

                    b.Property<double>("DisplaySize")
                        .HasColumnType("float");

                    b.Property<string>("Resolution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Products", t =>
                        {
                            t.Property("DisplaySize")
                                .HasColumnName("Television_DisplaySize");
                        });

                    b.HasDiscriminator().HasValue("Television");
                });

            modelBuilder.Entity("ECommerce.Models.Laptop", b =>
                {
                    b.HasBaseType("ECommerce.Models.Product");

                    b.Property<double>("DisplaySize")
                        .HasColumnType("float");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RAM")
                        .HasColumnType("int");

                    b.Property<int>("ROM")
                        .HasColumnType("int");

                    b.ToTable("Products", t =>
                        {
                            t.Property("DisplaySize")
                                .HasColumnName("Laptop_DisplaySize");
                        });

                    b.HasDiscriminator().HasValue("Laptop");
                });

            modelBuilder.Entity("ECommerce.Models.Phone", b =>
                {
                    b.HasBaseType("ECommerce.Models.Product");

                    b.Property<int>("BatteryCapacity")
                        .HasColumnType("int");

                    b.Property<double>("DisplaySize")
                        .HasColumnType("float");

                    b.Property<int?>("FrontCamera")
                        .HasColumnType("int");

                    b.Property<int>("MainCamera")
                        .HasColumnType("int");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.ToTable("Products");

                    b.HasDiscriminator().HasValue("Phone");
                });

            modelBuilder.Entity("ECommerce.Models.Product", b =>
                {
                    b.HasOne("ECommerce.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("ECommerce.Models.Seria", "Seria")
                        .WithMany("Products")
                        .HasForeignKey("SeriaId");

                    b.Navigation("Manufacturer");

                    b.Navigation("Seria");
                });

            modelBuilder.Entity("ECommerce.Models.Review", b =>
                {
                    b.HasOne("ECommerce.Models.Product", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Models.Seria", b =>
                {
                    b.HasOne("ECommerce.Models.Manufacturer", "Manufacturer")
                        .WithMany("Serias")
                        .HasForeignKey("ManufacturerId");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("ECommerce.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Serias");
                });

            modelBuilder.Entity("ECommerce.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ECommerce.Models.Seria", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
