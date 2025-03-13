using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEditionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditionId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Editions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_EditionId",
                table: "Books",
                column: "EditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Editions_EditionId",
                table: "Books",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Editions_EditionId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Editions");

            migrationBuilder.DropIndex(
                name: "IX_Books_EditionId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "EditionId",
                table: "Books");
        }
    }
}
