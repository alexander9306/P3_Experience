﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema.Api.Datos;

namespace Sistema.Api.Migrations
{
    [DbContext(typeof(DbContextSistema))]
    partial class DbContextSistemaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Sistema.Api.Entidades.Almacen.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 895, DateTimeKind.Local).AddTicks(3714),
                            Descripcion = "Celulares nuevos y usados.",
                            Estado = true,
                            Nombre = "Celulares",
                            UpdatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 896, DateTimeKind.Local).AddTicks(1086)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 896, DateTimeKind.Local).AddTicks(1441),
                            Descripcion = "Tenemos computadoras de ultima generacion.",
                            Estado = true,
                            Nombre = "Computadoras",
                            UpdatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 896, DateTimeKind.Local).AddTicks(1450)
                        });
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Almacen.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marca")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9184),
                            Descripcion = "Los clientes empresariales han utilizado durante mucho tiempo la familia de portátiles empresariales de gama alta Lenovo, anteriormente IBM, ThinkPad",
                            Estado = true,
                            Marca = "Lenovo",
                            Nombre = "Thinkpad T440 - Nuevo",
                            Precio = 55000.00m,
                            Stock = 15,
                            UpdatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(8887)
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9519),
                            Estado = true,
                            Marca = "Dell",
                            Nombre = "Latitude E6540 - Nuevo",
                            Precio = 44000.00m,
                            Stock = 5,
                            UpdatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9512)
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9528),
                            Estado = true,
                            Marca = "Huawei",
                            Nombre = "Honor 20 - Nuevo",
                            Precio = 34000.00m,
                            Stock = 10,
                            UpdatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9527)
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9531),
                            Estado = true,
                            Marca = "Lenovo",
                            Nombre = "Lenovo L34 - Nuevo",
                            Precio = 40000.00m,
                            Stock = 10,
                            UpdatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 897, DateTimeKind.Local).AddTicks(9530)
                        });
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Almacen.ProductoFoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FotoPublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsPrincipal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductoFotos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 900, DateTimeKind.Local).AddTicks(4299),
                            FotoPublicId = "Sistema-Ventas/Laptops/Laptop%20Lenovo%20Thinkpad%20T440%20%E2%80%93%20Intel%20Core%20i5-4200U%20%E2%80%93%208GB%20RAM%20%E2%80%93%20500GB%20HDD%20%E2%80%93%20Teclado%20Num%C3%A9rico%20%E2%80%93%20Lector%20De%20Huellas/Laptop_Lenovo_Thinkpad_T440_Intel_Core_i5-4200U_8GB_RAM_500GB_HDD_Teclado_Num%C3%A9rico_Lector_De_Huellas_lenodiK59HL_bfzqjo.jpg",
                            FotoUrl = "https://res.cloudinary.com/alexander-damaso-26857/image/upload/v1595816989/Sistema-Ventas/Laptops/Laptop Lenovo Thinkpad T440 – Intel Core i5-4200U – 8GB RAM – 500GB HDD – Teclado Numérico – Lector De Huellas/Laptop_Lenovo_Thinkpad_T440_Intel_Core_i5-4200U_8GB_RAM_500GB_HDD_Teclado_Numérico_Lector_De_Huellas_lenodiK59HL_bfzqjo.jpg",
                            ProductoId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 900, DateTimeKind.Local).AddTicks(4894),
                            FotoPublicId = "Sistema-Ventas/Laptops/Laptop%20Lenovo%20Thinkpad%20T440%20%E2%80%93%20Intel%20Core%20i5-4200U%20%E2%80%93%208GB%20RAM%20%E2%80%93%20500GB%20HDD%20%E2%80%93%20Teclado%20Num%C3%A9rico%20%E2%80%93%20Lector%20De%20Huellas/Laptop_Lenovo_Thinkpad_T440_Intel_Core_i5-4200U_8GB_RAM_500GB_HDD_Teclado_Num%C3%A9rico_Lector_De_Huellas_81giqVlenosi_m4gfmm.jpg",
                            FotoUrl = "https://res.cloudinary.com/alexander-damaso-26857/image/upload/v1595816989/Sistema-Ventas/Laptops/Laptop Lenovo Thinkpad T440 – Intel Core i5-4200U – 8GB RAM – 500GB HDD – Teclado Numérico – Lector De Huellas/Laptop_Lenovo_Thinkpad_T440_Intel_Core_i5-4200U_8GB_RAM_500GB_HDD_Teclado_Numérico_Lector_De_Huellas_710c9klejuso_mn1uht.jpg",
                            ProductoId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 900, DateTimeKind.Local).AddTicks(4994),
                            FotoPublicId = "Sistema-Ventas/Laptops/Laptop%20Lenovo%20Thinkpad%20T440%20%E2%80%93%20Intel%20Core%20i5-4200U%20%E2%80%93%208GB%20RAM%20%E2%80%93%20500GB%20HDD%20%E2%80%93%20Teclado%20Num%C3%A9rico%20%E2%80%93%20Lector%20De%20Huellas/Laptop_Lenovo_Thinkpad_T440_Intel_Core_i5-4200U_8GB_RAM_500GB_HDD_Teclado_Num%C3%A9rico_Lector_De_Huellas_710c9klejuso_mn1uht.jpg",
                            FotoUrl = "https://res.cloudinary.com/alexander-damaso-26857/image/upload/v1595816989/Sistema-Ventas/Laptops/Laptop Lenovo Thinkpad T440 – Intel Core i5-4200U – 8GB RAM – 500GB HDD – Teclado Numérico – Lector De Huellas/Laptop_Lenovo_Thinkpad_T440_Intel_Core_i5-4200U_8GB_RAM_500GB_HDD_Teclado_Numérico_Lector_De_Huellas_81giqVlenosi_m4gfmm.jpg",
                            ProductoId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 900, DateTimeKind.Local).AddTicks(5076),
                            FotoPublicId = "Sistema-Ventas/Laptops/Dell%20Latitude%20E6540%20%E2%80%93%20Full%20HD%20%E2%80%93%20Core%20i5%204th%20Gen%20%E2%80%93%2016GB%20RAM%20%E2%80%93%20500GB%20%E2%80%93%20Teclado%20Num%C3%A9rico/Dell_Latitude_E6540_Full_HD_Core_i5_4th_Gen_16GB_RAM_500GB_Teclado_Num%C3%A9rico_776540h7hdell_kwtv8a.jpg",
                            FotoUrl = "https://res.cloudinary.com/alexander-damaso-26857/image/upload/v1595816981/Sistema-Ventas/Laptops/Dell Latitude E6540 – Full HD – Core i5 4th Gen – 16GB RAM – 500GB – Teclado Numérico/Dell_Latitude_E6540_Full_HD_Core_i5_4th_Gen_16GB_RAM_500GB_Teclado_Numérico_776540h7hdell_kwtv8a.jpg",
                            ProductoId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 7, 26, 23, 33, 57, 900, DateTimeKind.Local).AddTicks(5149),
                            FotoPublicId = "Sistema-Ventas/Celulares/Huawei%20Honor%2020/Huawei_Honor_20_funda_de_silicona_huawei_honor_20_02_transparente_ad_l_uyu1kx.jpg",
                            FotoUrl = "https://res.cloudinary.com/alexander-damaso-26857/image/upload/v1595816944/Sistema-Ventas/Celulares/Huawei Honor 20/Huawei_Honor_20_funda_de_silicona_huawei_honor_20_02_transparente_ad_l_uyu1kx.jpg",
                            ProductoId = 3
                        });
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Carrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteGuid")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.DetalleCarrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarritoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarritoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetalleCarritos");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarritoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarritoId")
                        .IsUnique();

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId")
                        .IsUnique();

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId")
                        .IsUnique();

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Usuario.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RolId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RolId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Usuario.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Usuario.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Acceso máximo del sistema.",
                            Estado = false,
                            Nombre = "Administrador"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Acceso a las ordenes del sistema.",
                            Estado = false,
                            Nombre = "Organizador"
                        });
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Almacen.Producto", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Almacen.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Almacen.ProductoFoto", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Almacen.Producto", null)
                        .WithMany("Fotos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Carrito", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Usuario.Cliente", "Cliente")
                        .WithOne("Carrito")
                        .HasForeignKey("Sistema.Api.Entidades.Ordenes.Carrito", "ClienteId");
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.DetalleCarrito", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Ordenes.Carrito", "Carrito")
                        .WithMany("Detalles")
                        .HasForeignKey("CarritoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema.Api.Entidades.Almacen.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Orden", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Ordenes.Carrito", null)
                        .WithOne("Orden")
                        .HasForeignKey("Sistema.Api.Entidades.Ordenes.Orden", "CarritoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema.Api.Entidades.Usuario.Cliente", null)
                        .WithOne("Orden")
                        .HasForeignKey("Sistema.Api.Entidades.Ordenes.Orden", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Pago", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Ordenes.Orden", "Orden")
                        .WithOne("Pago")
                        .HasForeignKey("Sistema.Api.Entidades.Ordenes.Pago", "OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Ordenes.Pedido", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Ordenes.Orden", "Orden")
                        .WithOne("Pedido")
                        .HasForeignKey("Sistema.Api.Entidades.Ordenes.Pedido", "OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema.Api.Entidades.Usuario.Administrador", b =>
                {
                    b.HasOne("Sistema.Api.Entidades.Usuario.Rol", "Rol")
                        .WithMany("Administradores")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
