using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "FARYVET");

            migrationBuilder.CreateTable(
                name: "FARYVET_FLS_Conductor",
                schema: "FARYVET",
                columns: table => new
                {
                    NumeroIdentificacion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    PrimerApellido = table.Column<string>(nullable: false),
                    SegundoApellido = table.Column<string>(nullable: false),
                    FechaContratacion = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    IsEntrega = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FARYVET_FLS_Conductor", x => x.NumeroIdentificacion);
                });

            migrationBuilder.CreateTable(
                name: "FARYVET_FLS_VehiculoTransporte",
                schema: "FARYVET",
                columns: table => new
                {
                    NumeroPlaca = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    AnnioFabricacion = table.Column<int>(nullable: false),
                    CapacidadCarga = table.Column<float>(nullable: false),
                    CapacidadCombustible = table.Column<float>(nullable: false),
                    FechaRiteve = table.Column<DateTime>(nullable: false),
                    CostoMarchamo = table.Column<float>(nullable: false),
                    CVOSenasa = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    IsEntrega = table.Column<bool>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    LicenciaRequerida = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FARYVET_FLS_VehiculoTransporte", x => x.NumeroPlaca);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FARYVET_FLS_Conductor",
                schema: "FARYVET");

            migrationBuilder.DropTable(
                name: "FARYVET_FLS_VehiculoTransporte",
                schema: "FARYVET");
        }
    }
}
