﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SO.Data.ORM;

namespace SO.Data.Migrations
{
    [DbContext(typeof(SaleOnlineDbContext))]
    [Migration("20210902190724_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("SO.Domain.Entity.CostPurchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<decimal>("Value")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,5)")
                        .HasDefaultValue(0m)
                        .HasColumnName("VALUE");

                    b.HasKey("Id")
                        .HasName("ID");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("SO_COST_PURCHASE");
                });

            modelBuilder.Entity("SO.Domain.Entity.ExpenseTotal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("STORE_ID");

                    b.Property<decimal>("Value")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,5)")
                        .HasDefaultValue(0m)
                        .HasColumnName("VALUE");

                    b.HasKey("Id")
                        .HasName("ID");

                    b.HasIndex("StoreId")
                        .IsUnique();

                    b.ToTable("SO_EXPENSE_TOTAL");
                });

            modelBuilder.Entity("SO.Domain.Entity.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("clob")
                        .HasColumnName("IMAGE");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PRODUCT_ID");

                    b.HasKey("Id")
                        .HasName("ID");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("SO_PHOTO");
                });

            modelBuilder.Entity("SO.Domain.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("NAME");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,5)")
                        .HasDefaultValue(0m)
                        .HasColumnName("PRICE");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("STORE_ID");

                    b.HasKey("Id")
                        .HasName("ID");

                    b.HasIndex("StoreId");

                    b.ToTable("SO_PRODUCT");
                });

            modelBuilder.Entity("SO.Domain.Entity.SalePrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<decimal?>("ProfitMargin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,5)")
                        .HasDefaultValue(0m)
                        .HasColumnName("PROFIT_MARGIN");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(10,5)")
                        .HasColumnName("VALUE");

                    b.HasKey("Id")
                        .HasName("ID");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("SO_SALE_PRICE");
                });

            modelBuilder.Entity("SO.Domain.Entity.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("ID");

                    b.ToTable("SO_STORE");
                });

            modelBuilder.Entity("SO.Domain.Entity.CostPurchase", b =>
                {
                    b.HasOne("SO.Domain.Entity.Product", "Product")
                        .WithOne("CostPurchase")
                        .HasForeignKey("SO.Domain.Entity.CostPurchase", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SO.Domain.Entity.ExpenseTotal", b =>
                {
                    b.HasOne("SO.Domain.Entity.Store", "Store")
                        .WithOne("ExpenseTotal")
                        .HasForeignKey("SO.Domain.Entity.ExpenseTotal", "StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SO.Domain.Entity.Photo", b =>
                {
                    b.HasOne("SO.Domain.Entity.Product", "Product")
                        .WithOne("Photo")
                        .HasForeignKey("SO.Domain.Entity.Photo", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SO.Domain.Entity.Product", b =>
                {
                    b.HasOne("SO.Domain.Entity.Store", "Store")
                        .WithMany("Products")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SO.Domain.Entity.SalePrice", b =>
                {
                    b.HasOne("SO.Domain.Entity.Product", "Product")
                        .WithOne("SalePrice")
                        .HasForeignKey("SO.Domain.Entity.SalePrice", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SO.Domain.Entity.Product", b =>
                {
                    b.Navigation("CostPurchase");

                    b.Navigation("Photo");

                    b.Navigation("SalePrice");
                });

            modelBuilder.Entity("SO.Domain.Entity.Store", b =>
                {
                    b.Navigation("ExpenseTotal");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}