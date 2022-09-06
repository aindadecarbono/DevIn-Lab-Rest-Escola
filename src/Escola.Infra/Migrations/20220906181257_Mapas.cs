using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Infra.Migrations
{
    public partial class Mapas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SOBRENOME",
                table: "ALUNO",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "ALUNO",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL",
                table: "ALUNO",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateTable(
                name: "BOLETIM",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ALUNO_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    APROVADO = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoletimId", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BOLETIM_ALUNO_ALUNO_ID",
                        column: x => x.ALUNO_ID,
                        principalTable: "ALUNO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MATERIA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaID", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NOTAS MATERIA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BOLETIM_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MATERIA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOTA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasMateriaID", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NOTAS MATERIA_BOLETIM_BOLETIM_ID",
                        column: x => x.BOLETIM_ID,
                        principalTable: "BOLETIM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NOTAS MATERIA_MATERIA_MATERIA_ID",
                        column: x => x.MATERIA_ID,
                        principalTable: "MATERIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ALUNO_Matricula",
                table: "ALUNO",
                column: "Matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BOLETIM_ALUNO_ID",
                table: "BOLETIM",
                column: "ALUNO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOTAS MATERIA_BOLETIM_ID",
                table: "NOTAS MATERIA",
                column: "BOLETIM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_NOTAS MATERIA_MATERIA_ID",
                table: "NOTAS MATERIA",
                column: "MATERIA_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NOTAS MATERIA");

            migrationBuilder.DropTable(
                name: "BOLETIM");

            migrationBuilder.DropTable(
                name: "MATERIA");

            migrationBuilder.DropIndex(
                name: "IX_ALUNO_Matricula",
                table: "ALUNO");

            migrationBuilder.AlterColumn<string>(
                name: "SOBRENOME",
                table: "ALUNO",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "ALUNO",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL",
                table: "ALUNO",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
