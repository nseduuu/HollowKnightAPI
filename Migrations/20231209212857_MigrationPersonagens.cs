using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HollowKnightAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPersonagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ITENS_Personagem_PersonagemId",
                table: "TB_ITENS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_MOBS_Personagem_PersonagemId",
                table: "TB_MOBS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personagem",
                table: "Personagem");

            migrationBuilder.RenameTable(
                name: "Personagem",
                newName: "TB_PERSONAGENS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PERSONAGENS",
                table: "TB_PERSONAGENS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ITENS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ITENS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_MOBS_TB_PERSONAGENS_PersonagemId",
                table: "TB_MOBS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ITENS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ITENS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_MOBS_TB_PERSONAGENS_PersonagemId",
                table: "TB_MOBS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PERSONAGENS",
                table: "TB_PERSONAGENS");

            migrationBuilder.RenameTable(
                name: "TB_PERSONAGENS",
                newName: "Personagem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personagem",
                table: "Personagem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ITENS_Personagem_PersonagemId",
                table: "TB_ITENS",
                column: "PersonagemId",
                principalTable: "Personagem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_MOBS_Personagem_PersonagemId",
                table: "TB_MOBS",
                column: "PersonagemId",
                principalTable: "Personagem",
                principalColumn: "Id");
        }
    }
}
