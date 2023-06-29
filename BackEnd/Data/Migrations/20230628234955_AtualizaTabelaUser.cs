using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaTabelaUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                               name: "CNPJ",
                                table: "Users");

            migrationBuilder.RenameColumn(
                               name: "CPF",
                                              table: "Users",
                                                             newName: "CpfCnpj");

            migrationBuilder.AddColumn<String>(
            name: "TipoPessoa",
            table: "Users",
            type: "nvarchar(1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPessoa",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CpfCnpj",
                table: "Users",
                newName: "CPF");

            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
