﻿// <auto-generated />
using GoodsCatalog.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoodsCatalog.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GoodsCatalog.Models.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("GoodName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("good_name");

                    b.Property<int>("GoodsManufactureId")
                        .HasColumnType("integer")
                        .HasColumnName("good_manufacture");

                    b.Property<int>("GoodsTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("good_type");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("goods_pkey");

                    b.HasIndex("GoodsManufactureId");

                    b.HasIndex("GoodsTypeId");

                    b.ToTable("goods", (string)null);
                });

            modelBuilder.Entity("GoodsCatalog.Models.GoodsManufacture", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("goods_manufacture_pkey");

                    b.ToTable("goods_manufacture", (string)null);
                });

            modelBuilder.Entity("GoodsCatalog.Models.GoodsType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("goods_types_pkey");

                    b.ToTable("goods_types", (string)null);
                });

            modelBuilder.Entity("GoodsCatalog.Models.Good", b =>
                {
                    b.HasOne("GoodsCatalog.Models.GoodsManufacture", "GoodsManufacture")
                        .WithMany("Goods")
                        .HasForeignKey("GoodsManufactureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodsCatalog.Models.GoodsType", "GoodsType")
                        .WithMany("Goods")
                        .HasForeignKey("GoodsTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoodsManufacture");

                    b.Navigation("GoodsType");
                });

            modelBuilder.Entity("GoodsCatalog.Models.GoodsManufacture", b =>
                {
                    b.Navigation("Goods");
                });

            modelBuilder.Entity("GoodsCatalog.Models.GoodsType", b =>
                {
                    b.Navigation("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}
