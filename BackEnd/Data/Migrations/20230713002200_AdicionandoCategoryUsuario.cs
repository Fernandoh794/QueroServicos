using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCategoryUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Users",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Users");
        }
    }
}
