using Microsoft.EntityFrameworkCore.Migrations;

namespace LivrariaAPI.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_person_editorid",
                table: "book");

            migrationBuilder.DropIndex(
                name: "IX_book_editorid",
                table: "book");

            migrationBuilder.DropColumn(
                name: "editorid",
                table: "book");

            migrationBuilder.AddColumn<int>(
                name: "anoLancamento",
                table: "book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "editor",
                table: "book",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anoLancamento",
                table: "book");

            migrationBuilder.DropColumn(
                name: "editor",
                table: "book");

            migrationBuilder.AddColumn<long>(
                name: "editorid",
                table: "book",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_book_editorid",
                table: "book",
                column: "editorid");

            migrationBuilder.AddForeignKey(
                name: "FK_book_person_editorid",
                table: "book",
                column: "editorid",
                principalTable: "person",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
