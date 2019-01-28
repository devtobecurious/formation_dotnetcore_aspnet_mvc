using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestleheros.Core.Data.Migrations
{
    public partial class EstInitialParagraphe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstInitial",
                table: "Paragraphe",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstInitial",
                table: "Paragraphe");
        }
    }
}
