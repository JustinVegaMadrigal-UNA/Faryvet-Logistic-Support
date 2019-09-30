using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaryvetLogisticSupport.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRiteve",
                table: "FARYVET_FLS_VehiculoTransporte",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FechaRiteve",
                table: "FARYVET_FLS_VehiculoTransporte",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
