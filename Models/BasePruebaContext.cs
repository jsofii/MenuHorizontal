using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MenuHorizontal.Models
{
    public partial class BasePruebaContext : DbContext
    {
        public BasePruebaContext()
        {
        }

        public BasePruebaContext(DbContextOptions<BasePruebaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<MovimientoCuenta> MovimientoCuenta { get; set; }
        public virtual DbSet<MovimientoPres> MovimientoPres { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<TipoPrestamo> TipoPrestamo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=UIO27\\SQL2016;Database=BasePrueba;User Id=sa;Password=Sifizsoft1; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.Property(e => e.IdCuenta)
                    .HasColumnName("idCuenta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Disponible).HasColumnName("disponible");

                entity.Property(e => e.IdTipoCuenta).HasColumnName("idTipoCuenta");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("idUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCuenta).HasColumnName("numeroCuenta");

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithOne(p => p.InverseIdCuentaNavigation)
                    .HasForeignKey<Cuenta>(d => d.IdCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Usuario");
            });

            modelBuilder.Entity<MovimientoCuenta>(entity =>
            {
                entity.HasKey(e => e.IdMovimientoCuenta);

                entity.Property(e => e.IdMovimientoCuenta)
                    .HasColumnName("idMovimientoCuenta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdTipoMovimiento).HasColumnName("idTipoMovimiento");

                entity.Property(e => e.NumDocumento).HasColumnName("numDocumento");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdMovimientoCuentaNavigation)
                    .WithOne(p => p.InverseIdMovimientoCuentaNavigation)
                    .HasForeignKey<MovimientoCuenta>(d => d.IdMovimientoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoMovimiento_TipoMovimiento");
            });

            modelBuilder.Entity<MovimientoPres>(entity =>
            {
                entity.HasKey(e => e.IdMovimientoPrestamo);

                entity.Property(e => e.IdMovimientoPrestamo)
                    .HasColumnName("idMovimientoPrestamo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Capital).HasColumnName("capital");

                entity.Property(e => e.Cuota).HasColumnName("cuota");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");

                entity.Property(e => e.NumDocumento).HasColumnName("numDocumento");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdMovimientoPrestamoNavigation)
                    .WithOne(p => p.InverseIdMovimientoPrestamoNavigation)
                    .HasForeignKey<MovimientoPres>(d => d.IdMovimientoPrestamo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_idPrestamo_idPrestamo");
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo);

                entity.Property(e => e.IdPrestamo)
                    .HasColumnName("idPrestamo")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdTipoPrestamo).HasColumnName("idTipoPrestamo");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasColumnName("moneda")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.Property(e => e.ValorDia).HasColumnName("valorDia");

                entity.HasOne(d => d.IdPrestamoNavigation)
                    .WithOne(p => p.InverseIdPrestamoNavigation)
                    .HasForeignKey<Prestamo>(d => d.IdPrestamo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Prestamo");
            });

            modelBuilder.Entity<TipoCuenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuenta);

                entity.Property(e => e.IdTipoCuenta)
                    .HasColumnName("idTipoCuenta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimiento);

                entity.ToTable("tipoMovimiento");

                entity.Property(e => e.IdTipoMovimiento)
                    .HasColumnName("idTipoMovimiento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPrestamo>(entity =>
            {
                entity.HasKey(e => e.IdTipoPrestamo);

                entity.Property(e => e.IdTipoPrestamo)
                    .HasColumnName("idTipoPrestamo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("idUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("nombreUsuario")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
