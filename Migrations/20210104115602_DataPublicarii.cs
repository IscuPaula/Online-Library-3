using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Proiect_Iscu_Paula.Models;

namespace Proiect_Iscu_Paula.Migrations
{
    public partial class DataPublicarii : Migration
    {
        public int ID { get; internal set; }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Haine",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPublicarii",
                table: "Haine",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPublicarii",
                table: "Haine");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pret",
                table: "Haine",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");
        }

        public static implicit operator DataPublicarii(Publicare v)
        {
            throw new NotImplementedException();
        }
    }
}
