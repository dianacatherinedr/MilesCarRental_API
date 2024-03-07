﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilesCarRenta_API;

#nullable disable

namespace MilesCarRenta_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MilesCarRenta_API.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Engine_capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location_id")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vehicule_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Chevrolet",
                            Created_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3098),
                            Engine_capacity = "1600cc",
                            Location_id = 1,
                            Model = "2018",
                            Plate_number = "PTH15E",
                            Status = "D",
                            Updated_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3112),
                            Vehicule_type = "Camioneta"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Chevrolet",
                            Created_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3115),
                            Engine_capacity = "1200cc",
                            Location_id = 1,
                            Model = "2022",
                            Plate_number = "KNQ32",
                            Status = "D",
                            Updated_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3115),
                            Vehicule_type = "Automovil"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Mazda",
                            Created_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3117),
                            Engine_capacity = "1400cc",
                            Location_id = 2,
                            Model = "2009",
                            Plate_number = "ATR21",
                            Status = "O",
                            Updated_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3117),
                            Vehicule_type = "Automovil"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Nissan",
                            Created_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3119),
                            Engine_capacity = "1600cc",
                            Location_id = 3,
                            Model = "2017",
                            Plate_number = "KNP98",
                            Status = "O",
                            Updated_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3119),
                            Vehicule_type = "Campero"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Nissan",
                            Created_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3121),
                            Engine_capacity = "1600cc",
                            Location_id = 4,
                            Model = "2017",
                            Plate_number = "KNP98",
                            Status = "O",
                            Updated_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3121),
                            Vehicule_type = "Campero"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Wolsvagen",
                            Created_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3122),
                            Engine_capacity = "1600cc",
                            Location_id = 3,
                            Model = "2007",
                            Plate_number = "ARS45",
                            Status = "D",
                            Updated_at = new DateTime(2024, 3, 7, 13, 25, 48, 597, DateTimeKind.Local).AddTicks(3123),
                            Vehicule_type = "Sub"
                        });
                });

            modelBuilder.Entity("MilesCarRenta_API.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Parque deportivo",
                            Latitude = 10.4881f,
                            Longitude = -66.8796f,
                            Name = "Parque Central",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Telecomunicaciones",
                            Latitude = 48.8584f,
                            Longitude = 2.2945f,
                            Name = "Torre Central",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Plaza principal",
                            Latitude = 55.7539f,
                            Longitude = 37.6208f,
                            Name = "Plaza de Bolivar",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Parque de Recreacion",
                            Latitude = -13.1631f,
                            Longitude = -72.545f,
                            Name = "Salitre Magico",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Estadio",
                            Latitude = 29.9792f,
                            Longitude = 31.1344f,
                            Name = "Movistar Arena",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MilesCarRenta_API.Models.ReturnOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Location_id")
                        .HasColumnType("int");

                    b.Property<string>("Name_receiving_mamanger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ReturnOptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = " CALLE 26 #35-180 ",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "La devolucion se realizará en horario de la tarde",
                            Location_id = 2,
                            Name_receiving_mamanger = "Luisa Quevedo",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Address = " CALLE 1N #185-96 ",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "La devolucion se realizará en horario de la mañana en el local directamente",
                            Location_id = 4,
                            Name_receiving_mamanger = "Maria Rojas",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Address = " CALLE 24N #259-123 ",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "La devolucion se realizará en horario de la mañana",
                            Location_id = 5,
                            Name_receiving_mamanger = "Camila Duque",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Address = " Carrera 15 #54-43 Bastilla Parqueadero ",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "La devolucion se realizará en horario laboral de 8 a 12 y de 2 a 6 en el parqueadero disponible",
                            Location_id = 5,
                            Name_receiving_mamanger = "Lorena Arias",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Address = " 80 con calle 10 #89-74",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "La devolucion se realizará en horario de la tarde en el local directamente",
                            Location_id = 3,
                            Name_receiving_mamanger = "Eliza Flores",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Address = "",
                            Created_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Esta locación no tiene opcion de devolución",
                            Location_id = 1,
                            Name_receiving_mamanger = "",
                            Updated_at = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
