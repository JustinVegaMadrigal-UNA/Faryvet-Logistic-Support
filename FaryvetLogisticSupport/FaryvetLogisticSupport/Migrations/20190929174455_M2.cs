using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FARYVET_FLS_VehiculoTransporte",
                columns: table => new
                {
                    NumeroPlaca = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    AnnioFabricacion = table.Column<int>(nullable: false),
                    CapacidadCarga = table.Column<float>(nullable: false),
                    CapacidadCombustible = table.Column<float>(nullable: false),
                    FechaRiteve = table.Column<string>(nullable: false),
                    CostoMarchamo = table.Column<float>(nullable: false),
                    CVOSenasa = table.Column<bool>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    IsEntrega = table.Column<bool>(nullable: false),
                    Comentario = table.Column<string>(nullable: false),
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
                name: "FARYVET_FLS_VehiculoTransporte");
        }
    }
}
