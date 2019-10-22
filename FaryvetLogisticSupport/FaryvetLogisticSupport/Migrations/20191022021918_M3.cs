using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEntrega",
                schema: "FARYVET",
                table: "FARYVET_FLS_VehiculoTransporte");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEntrega",
                schema: "FARYVET",
                table: "FARYVET_FLS_VehiculoTransporte",
                nullable: false,
                defaultValue: false);
        }
    }
}
