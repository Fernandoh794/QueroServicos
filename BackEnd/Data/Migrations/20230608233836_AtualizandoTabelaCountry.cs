using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelaCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acronym",
                table: "Countries",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Bacen",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name_pt",
                table: "Countries",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acronym",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Bacen",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "name_pt",
                table: "Countries");
        }
    }
}
