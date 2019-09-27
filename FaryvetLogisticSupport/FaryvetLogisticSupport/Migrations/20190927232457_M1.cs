using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FARYVET_FLS_Conductor",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FARYVET_FLS_Conductor");
        }
    }
}
