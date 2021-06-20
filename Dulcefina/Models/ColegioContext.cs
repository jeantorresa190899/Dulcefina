using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dulcefina.Models
{
    public partial class ColegioContext : DbContext
    {
        public ColegioContext()
        {
        }

        public ColegioContext(DbContextOptions<ColegioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }
        public virtual DbSet<Entrega> Entregas { get; set; }
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
        public virtual DbSet<Tortum> Torta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LENOVO-X220;Initial Catalog=PASTELERIA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__CATEGORI__4BD51FA56E5DC8C1");

                entity.ToTable("CATEGORIA");

                entity.Property(e => e.IdCategoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTE__23A341301358F0EF");

                entity.ToTable("CLIENTE");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASENA");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CORREO");

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DOMICILIO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.IdTorta })
                    .HasName("PK__DETALLE___0999758F7A4D80EA");

                entity.ToTable("DETALLE_PEDIDO");

                entity.Property(e => e.IdPedido)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdTorta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_TORTA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.IdTop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_TOP");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MENSAJE");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PRECIO");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__ID_PE__36B12243");

                entity.HasOne(d => d.IdTopNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdTop)
                    .HasConstraintName("FK__DETALLE_P__ID_TO__38996AB5");

                entity.HasOne(d => d.IdTortaNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdTorta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__ID_TO__37A5467C");
            });

            modelBuilder.Entity<Entrega>(entity =>
            {
                entity.HasKey(e => e.IdEntrega)
                    .HasName("PK__ENTREGA__2BD5DB9C3C463640");

                entity.ToTable("ENTREGA");

                entity.Property(e => e.IdEntrega)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_ENTREGA");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MONTO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PK__METODO_P__B68D23DF77C54457");

                entity.ToTable("METODO_PAGO");

                entity.Property(e => e.IdPago)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_PAGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__PEDIDO__A05C2F2ABE5F6049");

                entity.ToTable("PEDIDO");

                entity.Property(e => e.IdPedido)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_PEDIDO");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_EMISION");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdEntrega)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_ENTREGA");

                entity.Property(e => e.IdPago)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_PAGO");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("MONTO_TOTAL");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__PEDIDO__ID_CLIEN__32E0915F");

                entity.HasOne(d => d.IdEntregaNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdEntrega)
                    .HasConstraintName("FK__PEDIDO__ID_ENTRE__31EC6D26");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdPago)
                    .HasConstraintName("FK__PEDIDO__ID_PAGO__33D4B598");
            });

            modelBuilder.Entity<Topping>(entity =>
            {
                entity.HasKey(e => e.IdTop)
                    .HasName("PK__TOPPINGS__27BF3396834BF7A7");

                entity.ToTable("TOPPINGS");

                entity.Property(e => e.IdTop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_TOP");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PRECIO");
            });

            modelBuilder.Entity<Tortum>(entity =>
            {
                entity.HasKey(e => e.IdTorta)
                    .HasName("PK__TORTA__9C55AA5B819E5874");

                entity.ToTable("TORTA");

                entity.Property(e => e.IdTorta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_TORTA");

                entity.Property(e => e.Color)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOTO");

                entity.Property(e => e.IdCategoria)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.Porcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PORCION");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("PRECIO");

                entity.Property(e => e.Relleno)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("RELLENO");

                entity.Property(e => e.Sabor)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("SABOR");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Torta)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__TORTA__ID_CATEGO__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
