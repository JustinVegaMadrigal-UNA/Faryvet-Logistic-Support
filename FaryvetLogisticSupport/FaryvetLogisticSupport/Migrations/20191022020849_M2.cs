using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEntrega",
                schema: "FARYVET",
                table: "FARYVET_FLS_Conductor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEntrega",
                schema: "FARYVET",
                table: "FARYVET_FLS_Conductor",
                nullable: false,
                defaultValue: false);
        }
    }
}
