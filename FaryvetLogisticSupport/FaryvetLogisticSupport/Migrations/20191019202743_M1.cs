using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FLS_Facturas",
                schema: "FARYVET",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FormaDespacho = table.Column<string>(nullable: false),
                    Peso = table.Column<float>(nullable: false),
                    FormaCobro = table.Column<string>(nullable: false),
                    Moneda = table.Column<string>(nullable: false),
                    Cliente = table.Column<string>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true),
                    Provincia = table.Column<string>(nullable: false),
                    Canton = table.Column<string>(nullable: false),
                    Distrito = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FLS_Facturas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FLS_Facturas",
                schema: "FARYVET");
        }
    }
}
