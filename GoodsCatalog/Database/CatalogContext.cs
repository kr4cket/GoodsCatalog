using System;
using System.Collections.Generic;
using GoodsCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsCatalog.Database;

public partial class CatalogContext : DbContext
{
    public CatalogContext()
    {
    }

    public CatalogContext(DbContextOptions<CatalogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodsManufacture> GoodsManufactures { get; set; }

    public virtual DbSet<GoodsType> GoodsTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=catalog;Username=postgres;Password=1");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("goods_pkey");

            entity.ToTable("goods");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GoodsManufactureId).HasColumnName("good_manufacture");
            entity.Property(e => e.GoodName)
                .HasMaxLength(255)
                .HasColumnName("good_name");
            entity.Property(e => e.GoodsTypeId).HasColumnName("good_type");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<GoodsManufacture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("goods_manufacture_pkey");

            entity.ToTable("goods_manufacture");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GoodsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("goods_types_pkey");

            entity.ToTable("goods_types");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
