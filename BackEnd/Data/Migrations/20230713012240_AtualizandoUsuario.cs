using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_CategoryId",
                table: "Users",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CpfCnpj",
                table: "Users",
                column: "CpfCnpj",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CpfCnpj",
                table: "Users");
        }
    }
}
