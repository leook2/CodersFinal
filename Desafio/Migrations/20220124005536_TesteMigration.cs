using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio.Migrations
{
    public partial class TesteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    idDespesa = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    unidade = table.Column<int>(type: "INTEGER", nullable: false),
                    descricao = table.Column<string>(type: "TEXT", nullable: true),
                    tipoDespesa = table.Column<string>(type: "TEXT", nullable: true),
                    valor = table.Column<float>(type: "REAL", nullable: false),
                    vencimentoFatura = table.Column<DateTime>(type: "TEXT", nullable: false),
                    statusPagamento = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.idDespesa);
                });

            migrationBuilder.CreateTable(
                name: "Inquilinos",
                columns: table => new
                {
                    idInquilino = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    idade = table.Column<int>(type: "INTEGER", nullable: false),
                    sexo = table.Column<string>(type: "TEXT", nullable: true),
                    telefone = table.Column<int>(type: "INTEGER", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquilinos", x => x.idInquilino);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    idUnidade = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    identificacao = table.Column<int>(type: "INTEGER", nullable: false),
                    proprietario = table.Column<string>(type: "TEXT", nullable: true),
                    condominio = table.Column<string>(type: "TEXT", nullable: true),
                    cep = table.Column<int>(type: "INTEGER", nullable: false),
                    numero = table.Column<int>(type: "INTEGER", nullable: false),
                    rua = table.Column<string>(type: "TEXT", nullable: true),
                    bairro = table.Column<string>(type: "TEXT", nullable: true),
                    cidade = table.Column<string>(type: "TEXT", nullable: true),
                    estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.idUnidade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despesas");

            migrationBuilder.DropTable(
                name: "Inquilinos");

            migrationBuilder.DropTable(
                name: "Unidades");
        }
    }
}
