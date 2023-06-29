using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class InsertInTableStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                               name: "sigla",
                                              table: "states",
                                                             type: "varchar(2)",
                                                                            maxLength: 2,
                                                                                           nullable: false,
                                                                                                          defaultValue: "");


            migrationBuilder.Sql("INSERT INTO states (Name, sigla) VALUES ('Acre', 'AC'), ('Alagoas', 'AL'), ('Amapá', 'AP'), ('Amazonas', 'AM'),\r\n('Bahia', 'BA'), ('Ceará', 'CE'), ('Distrito Federal', 'DF'), ('Espírito Santo', 'ES'), ('Goiás', 'GO'), ('Maranhão', 'MA'),\r\n('Mato Grosso', 'MT'), ('Mato Grosso do Sul', 'MS'), ('Minas Gerais', 'MG'), ('Pará', 'PA'), ('Paraíba', 'PB'),\r\n('Paraná', 'PR'), ('Pernambuco', 'PE'), ('Piauí', 'PI'), ('Rio de Janeiro', 'RJ'), ('Rio Grande do Norte', 'RN'),\r\n('Rio Grande do Sul', 'RS'), ('Rondônia', 'RO'), ('Roraima', 'RR'), ('Santa Catarina', 'SC'), ('São Paulo', 'SP'),\r\n('Sergipe', 'SE'), ('Tocantins', 'TO');\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
