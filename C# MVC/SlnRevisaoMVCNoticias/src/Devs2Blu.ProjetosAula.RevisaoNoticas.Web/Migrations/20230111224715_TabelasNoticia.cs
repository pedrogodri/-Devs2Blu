using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Migrations
{
    public partial class TabelasNoticia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "noticia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    categoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noticia", x => x.id);
                    table.ForeignKey(
                        name: "FK_noticia_categoria_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categoria",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Análise" },
                    { 2, "Artigo" },
                    { 3, "Humor" },
                    { 4, "Crônicas" }
                });

            migrationBuilder.InsertData(
                table: "noticia",
                columns: new[] { "id", "categoriaId", "Descricao", "titulo" },
                values: new object[,]
                {
                    { 1, 1, "Segundo o último levantamento realizado pela equipe da Análise Editorial para produção do anuário ANÁLISE EXECUTIVOS JURÍDICOS E FINANCEIROS 2022 - edição especial de 15 anos - cerca de seis em cada dez departamentos - sendo eles jurídico, financeiro e de compliance - trabalham com políticas em prol da diversidade. Dentre os executivos que participaram da pesquisa, 30% preferiram não responder à questão.\r\n\r\nAs palestras e treinamentos para promoção de um ambiente empresarial mais inclusivo se destacam nos setores jurídico (83%), financeiro (84%) e de compliance (97%). Seguindo a mesma linha, o estímulo à criação de grupos temáticos e acessibilidade também ganham uma colocação alta com um média total de 70% e 59% para cada prática, respectivamente.", "Políticas de D&I são adotadas por 58% dos departamentos jurídico, financeiro e de compliance" },
                    { 2, 2, "Em 2020, o Estatuto da Criança e do Adolescente (ECA) faz 30 anos. Esse marco coincide com a pandemia causada pela COVID-19, que coloca em conflito noções de direito ligadas à preservação da vida e da liberdade apresentadas pelo próprio ECA. Diante desse contexto, este artigo trata a respeito de reinvenções e deslocamentos diante da quarentena, os quais se pautam pelo direito à vida ao mesmo tempo em que restringem o direito à liberdade. Ao assumir a inseparabilidade que Michel de Certeau postula quanto às noções de estratégia e tática, o artigo explora, metodologicamente, seis cenas expressivas da reinvenção do cotidiano – e que estão vinculadas, cada uma a seu modo, a três dimensões específicas: a relação de famílias com as tecnologias; a relação das famílias com a escola; e a relação das famílias com suas crianças. As quatro cenas iniciais, exploradas a partir da configuração de estratégia, indicam esforços para a conformação das formas de organização do social. Neste caso, fica evidente como, de um lado, a relação das famílias com as tecnologias, e, de outro, a relação das famílias com a escola sugerem práticas comprometidas com a manutenção de formas de existir, mesmo em meio a um contexto de excepcionalidade. As duas últimas cenas, situadas a partir da configuração de tática, dão visibilidade às práticas cotidianas das famílias com suas crianças, ou seja, ao que entendemos serem relatos de pessoas ordinárias e que, justamente por meio dessa condição, apontam possibilidades de criação do novo.", "A reinvenção do cotidiano em tempos de pandemia" },
                    { 3, 3, "Há um diálogo memorável em “O Nome da Rosa”, do escritor e intelectual italiano Umberto Eco (1932-2016), sobre a comédia e o riso. O personagem principal, Guilherme de Baskerville, entra em uma discussão com o monge Jorge de Burgos, um forte crítico não só da comédia, mas do riso em si, desde as de natureza intelectual – “O riso é incentivo à dúvida” – como as de natureza estética mesmo – “O riso sacode o corpo, deforma os traços fisionômicos”. A defesa de Guilherme, por sua vez, é mais intelectual – “O riso é próprio do homem, é sinal de sua racionalidade”. Mas é possível fazer também uma defesa científica do riso.\r\n\r\nUm estudo de 2020, conduzido por pesquisadores de universidades de Alemanha, Suíça e EUA, concluiu o que a nós pode parecer intuitivamente claro: o bom humor faz bem tanto para a vida pessoal como no ambiente de trabalho. O estudo envolveu pouco mais de 530 pessoas, e a ideia era fazer com que, por uma semana, o grupo, dividido em 4 subgrupos, se dedicasse a: fazer três coisas divertidas por dia; inovar no uso de alguma brincadeira; e enumerasse episódios divertidos do cotidiano (o quarto grupo foi o de controle). Três meses de acompanhamento depois, o estudo mostrou que o espírito do brincar acabou se incorporando à rotina.", "A ciência e o humor: pesquisas estudam os benefícios do riso para a saúde" },
                    { 4, 4, "Não é a Nova York das compras e do luxo que milhões de turistas buscam todos os anos. Mas esta Nova York, a oito quilômetros da agitada ilha de Manhattan, o coração da cidade, também vale uma visita. Bushwick é um bairro que literalmente redesenhou sua história.\r\n\r\nEntre os anos 80 e a primeira década de 2000, Bushwick era território de imigrantes italianos e latinos, gangues e traficantes. Era muito industrial e cinza. Mas artistas, locais e internacionais, organizados por coletivos deram cor a essa transformação. Eles criaram uma galeria de centenas de murais ao ar livre que vivem em constante mudança e que não para de crescer.", "Artistas usam ruas como galerias em bairro de Nova York" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_noticia_categoriaId",
                table: "noticia",
                column: "categoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "noticia");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}
