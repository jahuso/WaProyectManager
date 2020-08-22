﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectManager.Data.Context;

namespace ProjectManager.Data.Migrations
{
    [DbContext(typeof(PMContext))]
    partial class PMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManager.Data.Actividad", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.Property<int?>("ProyectoCodigo")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("ProyectoCodigo");

                    b.ToTable("Actividad");
                });

            modelBuilder.Entity("ProjectManager.Data.Documento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProyectoCodigo")
                        .HasColumnType("int");

                    b.Property<string>("Ruta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.HasIndex("ProyectoCodigo");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("ProjectManager.Data.Persona", b =>
                {
                    b.Property<string>("Identificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Programa")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Identificacion");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("ProjectManager.Data.Proyecto", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Equipo")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tutor")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("ProjectManager.Data.Tarea", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Proyecto")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("ProjectManager.Data.Actividad", b =>
                {
                    b.HasOne("ProjectManager.Data.Proyecto", null)
                        .WithMany("Actividades")
                        .HasForeignKey("ProyectoCodigo");
                });

            modelBuilder.Entity("ProjectManager.Data.Documento", b =>
                {
                    b.HasOne("ProjectManager.Data.Proyecto", null)
                        .WithMany("Documentos")
                        .HasForeignKey("ProyectoCodigo");
                });
#pragma warning restore 612, 618
        }
    }
}
