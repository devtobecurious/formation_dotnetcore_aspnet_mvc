using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontonestleheros.Core.Data.Migrations
{
    public partial class LienParagrapheSuivantReponses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParagrapheId",
                table: "Proposition",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Aventure",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proposition_ParagrapheId",
                table: "Proposition",
                column: "ParagrapheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proposition_Paragraphe_ParagrapheId",
                table: "Proposition",
                column: "ParagrapheId",
                principalTable: "Paragraphe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proposition_Paragraphe_ParagrapheId",
                table: "Proposition");

            migrationBuilder.DropIndex(
                name: "IX_Proposition_ParagrapheId",
                table: "Proposition");

            migrationBuilder.DropColumn(
                name: "ParagrapheId",
                table: "Proposition");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Aventure",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
