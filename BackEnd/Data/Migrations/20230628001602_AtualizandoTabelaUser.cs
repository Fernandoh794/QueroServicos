using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelaUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TIPO_PESSOA",
                table: "Users",
                newName: "TipoPessoa");

            migrationBuilder.RenameColumn(
                name: "CPF_CNPJ",
                table: "Users",
                newName: "CpfCnpj");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoPessoa",
                table: "Users",
                newName: "TIPO_PESSOA");

            migrationBuilder.RenameColumn(
                name: "CpfCnpj",
                table: "Users",
                newName: "CPF_CNPJ");
        }
    }
}
