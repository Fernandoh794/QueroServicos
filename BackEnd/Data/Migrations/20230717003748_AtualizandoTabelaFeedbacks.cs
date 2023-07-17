using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueroServicos.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoTabelaFeedbacks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserFeedback_UserId",
                table: "UserFeedback",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeedback_UserIdContratante",
                table: "UserFeedback",
                column: "UserIdContratante");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFeedback_Users_UserId",
                table: "UserFeedback",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFeedback_Users_UserIdContratante",
                table: "UserFeedback",
                column: "UserIdContratante",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFeedback_Users_UserId",
                table: "UserFeedback");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFeedback_Users_UserIdContratante",
                table: "UserFeedback");

            migrationBuilder.DropIndex(
                name: "IX_UserFeedback_UserId",
                table: "UserFeedback");

            migrationBuilder.DropIndex(
                name: "IX_UserFeedback_UserIdContratante",
                table: "UserFeedback");
        }
    }
}
