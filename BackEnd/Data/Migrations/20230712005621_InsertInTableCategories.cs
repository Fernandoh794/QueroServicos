using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class InsertInTableCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categories (Description) VALUES ('Peças e Auto'), ('Assistência Técnica'), ('Aulas'), ('Design e Software'), ('Eventos'), ('Moda e Beleza'), ('Reparos e Reformas'), ('Serviços Domésticos');\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
