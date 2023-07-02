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

            // mudar do tipo varchar para longtext
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "longtext",
                nullable: false );

            migrationBuilder.DropColumn(
                name: "Type" ,
                table: "Users" );

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int" );

            migrationBuilder.AlterColumn<int>(
                name: "SubcategoryId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int" );

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int" 
                );


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

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                               table: "Users",
                                              type: "varchar(60)",
                                                             maxLength: 60,
                                                                            nullable: false);
        }
    }
}
