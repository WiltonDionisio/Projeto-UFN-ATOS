using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto3.Migrations
{
    public partial class LocadoraForeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automovel_Locadora_LocadoraId",
                table: "Automovel");

            migrationBuilder.AlterColumn<int>(
                name: "LocadoraId",
                table: "Automovel",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Automovel_Locadora_LocadoraId",
                table: "Automovel",
                column: "LocadoraId",
                principalTable: "Locadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automovel_Locadora_LocadoraId",
                table: "Automovel");

            migrationBuilder.AlterColumn<int>(
                name: "LocadoraId",
                table: "Automovel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Automovel_Locadora_LocadoraId",
                table: "Automovel",
                column: "LocadoraId",
                principalTable: "Locadora",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
