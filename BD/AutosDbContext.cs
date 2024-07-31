using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BD;

public partial class AutosDbContext : DbContext
{
    public AutosDbContext()
    {
    }

    public AutosDbContext(DbContextOptions<AutosDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auto> Autos { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=ANGEL; Database=AutosDB; User=montes; Password=a; TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auto>(entity =>
        {
            entity.HasKey(e => e.AutoId).HasName("PK__Autos__6B23296585D087B5");

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.ModeloId).HasColumnName("ModeloID");
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Modelo).WithMany(p => p.Autos)
                .HasForeignKey(d => d.ModeloId)
                .HasConstraintName("FK__Autos__ModeloID__3C69FB99");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.MarcaId).HasName("PK__Marcas__D5B1CDEB8518D4F7");

            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.ModeloId).HasName("PK__Modelos__FA6052BA878E45B4");

            entity.Property(e => e.ModeloId).HasColumnName("ModeloID");
            entity.Property(e => e.MarcaId).HasColumnName("MarcaID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Marca).WithMany(p => p.Modelos)
                .HasForeignKey(d => d.MarcaId)
                .HasConstraintName("FK__Modelos__MarcaID__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
