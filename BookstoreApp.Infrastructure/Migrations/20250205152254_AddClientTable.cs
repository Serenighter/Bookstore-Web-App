using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ClientId",
                table: "Books",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Clients_ClientId",
                table: "Books",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Clients_ClientId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ClientId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Books");
        }
    }
}
