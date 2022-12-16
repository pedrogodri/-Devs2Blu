using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Migrations
{
    public partial class TabelasSistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filmes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lancamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classificacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmes", x => x.id);
                    table.ForeignKey(
                        name: "FK_filmes_categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Terror" },
                    { 2, "Ação e aventura" },
                    { 3, "Comédia" },
                    { 4, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "CategoriaId", "classificacao", "lancamento", "nome" },
                values: new object[,]
                {
                    { 1, 1, "16 anos", "21 de julho de 2022", "Telefone preto" },
                    { 2, 1, "16 anos", "7 de setembro de 2017", "It - A Coisa" },
                    { 3, 2, "12 anos", "25 de abril de 2019", "Vingadores: Ultimato" },
                    { 4, 2, "12 anos", "6 de julho de 2017", "Homem-Aranha: De Volta ao Lar" },
                    { 5, 3, "16 anos", "21 de setembro de 2012", "Ted" },
                    { 6, 3, "12 anos", "16 de agosto de 2013", "Gente Grande 2" },
                    { 7, 4, "12 anos", "5 de junho de 2014", "A Culpa É das Estrelas" },
                    { 8, 4, "16 anos", "28 de fevereiro de 2020", "Por Lugares Incríveis" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_filmes_CategoriaId",
                table: "filmes",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filmes");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
