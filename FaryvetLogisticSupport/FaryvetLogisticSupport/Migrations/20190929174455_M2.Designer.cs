﻿// <auto-generated />
using FaryvetLogisticSupport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaryvetLogisticSupport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190929174455_M2")]
    partial class M2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FaryvetLogisticSupport.Models.FARYVET_FLS_Conductor", b =>
                {
                    b.Property<string>("NumeroIdentificacion")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("FechaContratacion")
                        .IsRequired();

                    b.Property<bool>("IsEntrega");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("PrimerApellido")
                        .IsRequired();

                    b.Property<string>("SegundoApellido")
                        .IsRequired();

                    b.HasKey("NumeroIdentificacion");

                    b.ToTable("FARYVET_FLS_Conductor");
                });

            modelBuilder.Entity("FaryvetLogisticSupport.Models.FARYVET_FLS_VehiculoTransporte", b =>
                {
                    b.Property<string>("NumeroPlaca")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnioFabricacion");

                    b.Property<bool>("CVOSenasa");

                    b.Property<float>("CapacidadCarga");

                    b.Property<float>("CapacidadCombustible");

                    b.Property<string>("Comentario")
                        .IsRequired();

                    b.Property<float>("CostoMarchamo");

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("FechaRiteve")
                        .IsRequired();

                    b.Property<bool>("IsEntrega");

                    b.Property<string>("LicenciaRequerida")
                        .IsRequired();

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<string>("Modelo")
                        .IsRequired();

                    b.HasKey("NumeroPlaca");

                    b.ToTable("FARYVET_FLS_VehiculoTransporte");
                });
#pragma warning restore 612, 618
        }
    }
}