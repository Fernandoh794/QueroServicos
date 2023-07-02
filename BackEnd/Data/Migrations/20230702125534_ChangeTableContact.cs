using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // drop collumns Whatsapp, Telegram, Facebook and Instagram
            migrationBuilder.DropColumn(
                name: "Whatsapp",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Telegram",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Contact");

            // add collumn Phone
            migrationBuilder.AddColumn<string>(
               name: "Phone",
               table: "Contact",
               type: "varchar(13)",
               maxLength: 13,
               nullable: false);
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // drop collumn Phone
            migrationBuilder.DropColumn(
                               name: "Phone",
                                              table: "Contact");

            // add collumns Whatsapp, Telegram, Facebook and Instagram
            migrationBuilder.AddColumn<string>(
                               name: "Whatsapp",
                                              table: "Contact",
                                                             type: "varchar(13)",
                                                                            maxLength: 13,
                                                                                           nullable: false);

            migrationBuilder.AddColumn<string>(
                               name: "Telegram",
                                              table: "Contact",
                                                             type: "varchar(13)",
                                                                            maxLength: 13,
                                                                                           nullable: false);

            migrationBuilder.AddColumn<string>(
                               name: "Facebook",
                                              table: "Contact",
                                                             type: "varchar(13)",
                                                                            maxLength: 13,
                                                                                           nullable: false);

            migrationBuilder.AddColumn<string>(
                               name: "Instagram",
                                              table: "Contact",
                                                             type: "varchar(13)",
                                                                            maxLength: 13,
                                                                                           nullable: false);

        }
    }
}
