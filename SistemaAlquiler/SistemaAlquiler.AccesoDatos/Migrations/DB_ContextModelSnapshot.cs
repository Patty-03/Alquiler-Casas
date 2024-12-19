﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaAlquiler.AccesoDatos;

#nullable disable

namespace SistemaAlquiler.AccesoDatos.Migrations
{
    [DbContext(typeof(DB_Context))]
    partial class DB_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("jwt_Roles");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Caracteristicas", b =>
                {
                    b.Property<int>("idCaracteristicas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idCaracteristicas"));

                    b.Property<bool>("aguaCaliente")
                        .HasColumnType("boolean");

                    b.Property<bool>("barbacoa")
                        .HasColumnType("boolean");

                    b.Property<int>("cantBanos")
                        .HasColumnType("integer");

                    b.Property<int>("cantCuartos")
                        .HasColumnType("integer");

                    b.Property<int>("cantHabitaciones")
                        .HasColumnType("integer");

                    b.Property<int>("cantMaxPersonas")
                        .HasColumnType("integer");

                    b.Property<bool>("climatizada")
                        .HasColumnType("boolean");

                    b.Property<bool>("cocina")
                        .HasColumnType("boolean");

                    b.Property<bool>("garaje")
                        .HasColumnType("boolean");

                    b.Property<bool>("gimnasio")
                        .HasColumnType("boolean");

                    b.Property<bool>("lavadora_secadora")
                        .HasColumnType("boolean");

                    b.Property<bool>("permiteFumar")
                        .HasColumnType("boolean");

                    b.Property<bool>("permiteMascotas")
                        .HasColumnType("boolean");

                    b.Property<bool>("permiteMenores")
                        .HasColumnType("boolean");

                    b.Property<bool>("piscina")
                        .HasColumnType("boolean");

                    b.Property<bool>("terraza_balcon")
                        .HasColumnType("boolean");

                    b.Property<bool>("tv")
                        .HasColumnType("boolean");

                    b.Property<bool>("wifi")
                        .HasColumnType("boolean");

                    b.HasKey("idCaracteristicas");

                    b.ToTable("Caracteristicas");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Casa", b =>
                {
                    b.Property<int>("idCasa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idCasa"));

                    b.Property<double>("areaTotal")
                        .HasColumnType("double precision");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idCaracteristica")
                        .HasColumnType("integer");

                    b.Property<int?>("idCiudad")
                        .HasColumnType("integer");

                    b.Property<int?>("idUsuario")
                        .HasColumnType("integer");

                    b.Property<double>("precioMes")
                        .HasColumnType("double precision");

                    b.Property<double>("precioNoche")
                        .HasColumnType("double precision");

                    b.HasKey("idCasa");

                    b.HasIndex("idCaracteristica");

                    b.HasIndex("idCiudad");

                    b.HasIndex("idUsuario");

                    b.ToTable("Casas");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Ciudad", b =>
                {
                    b.Property<int>("idCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idCiudad"));

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("idCiudad");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Foto", b =>
                {
                    b.Property<int>("idFoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idFoto"));

                    b.Property<string>("direccionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("direccionURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idCasa")
                        .HasColumnType("integer");

                    b.HasKey("idFoto");

                    b.HasIndex("idCasa");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Reservacion", b =>
                {
                    b.Property<int>("idReservacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idReservacion"));

                    b.Property<int>("cantPersonas")
                        .HasColumnType("integer");

                    b.Property<double>("costoTotal")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("fechaEntrada")
                        .HasColumnType("date");

                    b.Property<DateOnly>("fechaSalida")
                        .HasColumnType("date");

                    b.Property<int>("idCasa")
                        .HasColumnType("integer");

                    b.Property<int>("idUsuario")
                        .HasColumnType("integer");

                    b.HasKey("idReservacion");

                    b.HasIndex("idCasa");

                    b.HasIndex("idUsuario");

                    b.ToTable("Reservaciones");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Rol", b =>
                {
                    b.Property<int>("idRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idRol"));

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("idRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idRol")
                        .HasColumnType("integer");

                    b.Property<string>("numeroContacto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idUsuario");

                    b.HasIndex("idRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Valoracion", b =>
                {
                    b.Property<int>("idValoracion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idValoracion"));

                    b.Property<string>("comentario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idCasa")
                        .HasColumnType("integer");

                    b.Property<int>("idUsuario")
                        .HasColumnType("integer");

                    b.Property<double>("puntuacion")
                        .HasColumnType("double precision");

                    b.HasKey("idValoracion");

                    b.HasIndex("idCasa");

                    b.HasIndex("idUsuario");

                    b.ToTable("Valoraciones");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Casa", b =>
                {
                    b.HasOne("SistemaAlquiler.Entidades.Caracteristicas", "caracteristicas")
                        .WithMany()
                        .HasForeignKey("idCaracteristica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAlquiler.Entidades.Ciudad", "ciudad")
                        .WithMany()
                        .HasForeignKey("idCiudad");

                    b.HasOne("SistemaAlquiler.Entidades.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("idUsuario");

                    b.Navigation("caracteristicas");

                    b.Navigation("ciudad");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Foto", b =>
                {
                    b.HasOne("SistemaAlquiler.Entidades.Casa", "casa")
                        .WithMany("fotos")
                        .HasForeignKey("idCasa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("casa");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Reservacion", b =>
                {
                    b.HasOne("SistemaAlquiler.Entidades.Casa", "casa")
                        .WithMany()
                        .HasForeignKey("idCasa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAlquiler.Entidades.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("casa");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Usuario", b =>
                {
                    b.HasOne("SistemaAlquiler.Entidades.Rol", "rol")
                        .WithMany()
                        .HasForeignKey("idRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("rol");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Valoracion", b =>
                {
                    b.HasOne("SistemaAlquiler.Entidades.Casa", "casa")
                        .WithMany()
                        .HasForeignKey("idCasa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaAlquiler.Entidades.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("casa");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("SistemaAlquiler.Entidades.Casa", b =>
                {
                    b.Navigation("fotos");
                });
#pragma warning restore 612, 618
        }
    }
}
