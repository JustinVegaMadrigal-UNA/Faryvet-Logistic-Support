﻿// <auto-generated />
using FaryvetLogisticSupport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaryvetLogisticSupport.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
