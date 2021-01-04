using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Iscu_Paula.Migrations
{
    public partial class Categorii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicareID",
                table: "Haine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categorii",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeleCategoriei = table.Column<string>(nullable: true),
                    CategoriiID = table.Column<int>(nullable: true),
                    HaineID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorii", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categorii_Categorii_CategoriiID",
                        column: x => x.CategoriiID,
                        principalTable: "Categorii",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categorii_Haine_HaineID",
                        column: x => x.HaineID,
                        principalTable: "Haine",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publicare",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumelePublicarii = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicare", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Haine_PublicareID",
                table: "Haine",
                column: "PublicareID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorii_CategoriiID",
                table: "Categorii",
                column: "CategoriiID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorii_HaineID",
                table: "Categorii",
                column: "HaineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Haine_Publicare_PublicareID",
                table: "Haine",
                column: "PublicareID",
                principalTable: "Publicare",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Haine_Publicare_PublicareID",
                table: "Haine");

            migrationBuilder.DropTable(
                name: "Categorii");

            migrationBuilder.DropTable(
                name: "Publicare");

            migrationBuilder.DropIndex(
                name: "IX_Haine_PublicareID",
                table: "Haine");

            migrationBuilder.DropColumn(
                name: "PublicareID",
                table: "Haine");
        }
    }
}
