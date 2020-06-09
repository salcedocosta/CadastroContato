using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ProjetoContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_contato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_contato = table.Column<string>(nullable: true),
                    dt_nascimento = table.Column<DateTime>(nullable: false),
                    sexo = table.Column<string>(nullable: true),
                    idade = table.Column<int>(nullable: false),
                    telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_contato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rastreio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_rastreio = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true),
                    dt_cadastro = table.Column<DateTime>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rastreio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_contato");

            migrationBuilder.DropTable(
                name: "tb_rastreio");
        }
    }
}
