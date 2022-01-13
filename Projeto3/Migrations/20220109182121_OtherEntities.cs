using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto3.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automovel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    placa = table.Column<int>(nullable: false),
                    Modelo = table.Column<string>(nullable: true),
                    AnoFabricacao = table.Column<DateTime>(nullable: false),
                    ValorAluguel = table.Column<double>(nullable: false),
                    LocadoraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automovel_Locadora_LocadoraId",
                        column: x => x.LocadoraId,
                        principalTable: "Locadora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VeiculoAlugados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AutomoveisId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculoAlugados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VeiculoAlugados_Automovel_AutomoveisId",
                        column: x => x.AutomoveisId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automovel_LocadoraId",
                table: "Automovel",
                column: "LocadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_VeiculoAlugados_AutomoveisId",
                table: "VeiculoAlugados",
                column: "AutomoveisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VeiculoAlugados");

            migrationBuilder.DropTable(
                name: "Automovel");
        }
    }
}
