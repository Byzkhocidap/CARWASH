using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CARWASH.Models
{
    public partial class CARWASHContext : DbContext
    {
        public CARWASHContext()
        {
        }

        public CARWASHContext(DbContextOptions<CARWASHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<EstadoFacturacion> EstadoFacturacions { get; set; } = null!;
        public virtual DbSet<Facturacion> Facturacions { get; set; } = null!;
        public virtual DbSet<Lavado> Lavados { get; set; } = null!;
        public virtual DbSet<TipoEmpledo> TipoEmpledos { get; set; } = null!;
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;
        public virtual DbSet<VehiculoLavado> VehiculoLavados { get; set; } = null!;
        public object Empleado { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(250)
                    .HasColumnName("apellido");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(250)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .HasColumnName("direccion");

                entity.Property(e => e.DocumentoIdentidad)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("documentoIdentidad");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaModificacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoEmpleadoId).HasColumnName("tipoEmpleadoId");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuarioCreacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuarioModificacion");

                entity.HasOne(d => d.TipoEmpleado)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.TipoEmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleado__tipoEm__46E78A0C");
            });

            modelBuilder.Entity<EstadoFacturacion>(entity =>
            {
                entity.ToTable("EstadoFacturacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Facturacion>(entity =>
            {
                entity.ToTable("Facturacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.EstatusFacturacionId).HasColumnName("estatusFacturacionId");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdEmplado).HasColumnName("idEmplado");

                entity.Property(e => e.LavadoId).HasColumnName("lavadoId");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculoId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__clien__49C3F6B7");

                entity.HasOne(d => d.EstatusFacturacion)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.EstatusFacturacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__estat__59063A47");

                entity.HasOne(d => d.IdEmpladoNavigation)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.IdEmplado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__idEmp__4AB81AF0");

                entity.HasOne(d => d.Lavado)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.LavadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__lavad__4CA06362");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__vehic__4BAC3F29");
            });

            modelBuilder.Entity<Lavado>(entity =>
            {
                entity.ToTable("Lavado");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoEmpledo>(entity =>
            {
                entity.ToTable("TipoEmpledo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.ToTable("TipoUsuario");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(255)
                    .HasColumnName("contrasena");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleadoId");

                entity.Property(e => e.TipoUsuarioId).HasColumnName("tipoUsuarioId");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(255)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__empleadoI__47DBAE45");

                entity.HasOne(d => d.TipoUsuario)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TipoUsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__tipoUsuar__48CFD27E");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("Vehiculo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<VehiculoLavado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VehiculoLavado");

                entity.Property(e => e.LavadoId).HasColumnName("lavadoId");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculoId");

                entity.HasOne(d => d.Lavado)
                    .WithMany()
                    .HasForeignKey(d => d.LavadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehiculoL__lavad__45F365D3");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany()
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehiculoL__vehic__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
