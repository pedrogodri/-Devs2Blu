﻿// <auto-generated />
using Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Migrations
{
    [DbContext(typeof(ContextDatabase))]
    [Migration("20230111224715_TabelasNoticia")]
    partial class TabelasNoticia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Análise"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Artigo"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Humor"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Crônicas"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("categoriaId");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("noticia");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descricao = "Segundo o último levantamento realizado pela equipe da Análise Editorial para produção do anuário ANÁLISE EXECUTIVOS JURÍDICOS E FINANCEIROS 2022 - edição especial de 15 anos - cerca de seis em cada dez departamentos - sendo eles jurídico, financeiro e de compliance - trabalham com políticas em prol da diversidade. Dentre os executivos que participaram da pesquisa, 30% preferiram não responder à questão.\r\n\r\nAs palestras e treinamentos para promoção de um ambiente empresarial mais inclusivo se destacam nos setores jurídico (83%), financeiro (84%) e de compliance (97%). Seguindo a mesma linha, o estímulo à criação de grupos temáticos e acessibilidade também ganham uma colocação alta com um média total de 70% e 59% para cada prática, respectivamente.",
                            Titulo = "Políticas de D&I são adotadas por 58% dos departamentos jurídico, financeiro e de compliance"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Descricao = "Em 2020, o Estatuto da Criança e do Adolescente (ECA) faz 30 anos. Esse marco coincide com a pandemia causada pela COVID-19, que coloca em conflito noções de direito ligadas à preservação da vida e da liberdade apresentadas pelo próprio ECA. Diante desse contexto, este artigo trata a respeito de reinvenções e deslocamentos diante da quarentena, os quais se pautam pelo direito à vida ao mesmo tempo em que restringem o direito à liberdade. Ao assumir a inseparabilidade que Michel de Certeau postula quanto às noções de estratégia e tática, o artigo explora, metodologicamente, seis cenas expressivas da reinvenção do cotidiano – e que estão vinculadas, cada uma a seu modo, a três dimensões específicas: a relação de famílias com as tecnologias; a relação das famílias com a escola; e a relação das famílias com suas crianças. As quatro cenas iniciais, exploradas a partir da configuração de estratégia, indicam esforços para a conformação das formas de organização do social. Neste caso, fica evidente como, de um lado, a relação das famílias com as tecnologias, e, de outro, a relação das famílias com a escola sugerem práticas comprometidas com a manutenção de formas de existir, mesmo em meio a um contexto de excepcionalidade. As duas últimas cenas, situadas a partir da configuração de tática, dão visibilidade às práticas cotidianas das famílias com suas crianças, ou seja, ao que entendemos serem relatos de pessoas ordinárias e que, justamente por meio dessa condição, apontam possibilidades de criação do novo.",
                            Titulo = "A reinvenção do cotidiano em tempos de pandemia"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 3,
                            Descricao = "Há um diálogo memorável em “O Nome da Rosa”, do escritor e intelectual italiano Umberto Eco (1932-2016), sobre a comédia e o riso. O personagem principal, Guilherme de Baskerville, entra em uma discussão com o monge Jorge de Burgos, um forte crítico não só da comédia, mas do riso em si, desde as de natureza intelectual – “O riso é incentivo à dúvida” – como as de natureza estética mesmo – “O riso sacode o corpo, deforma os traços fisionômicos”. A defesa de Guilherme, por sua vez, é mais intelectual – “O riso é próprio do homem, é sinal de sua racionalidade”. Mas é possível fazer também uma defesa científica do riso.\r\n\r\nUm estudo de 2020, conduzido por pesquisadores de universidades de Alemanha, Suíça e EUA, concluiu o que a nós pode parecer intuitivamente claro: o bom humor faz bem tanto para a vida pessoal como no ambiente de trabalho. O estudo envolveu pouco mais de 530 pessoas, e a ideia era fazer com que, por uma semana, o grupo, dividido em 4 subgrupos, se dedicasse a: fazer três coisas divertidas por dia; inovar no uso de alguma brincadeira; e enumerasse episódios divertidos do cotidiano (o quarto grupo foi o de controle). Três meses de acompanhamento depois, o estudo mostrou que o espírito do brincar acabou se incorporando à rotina.",
                            Titulo = "A ciência e o humor: pesquisas estudam os benefícios do riso para a saúde"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 4,
                            Descricao = "Não é a Nova York das compras e do luxo que milhões de turistas buscam todos os anos. Mas esta Nova York, a oito quilômetros da agitada ilha de Manhattan, o coração da cidade, também vale uma visita. Bushwick é um bairro que literalmente redesenhou sua história.\r\n\r\nEntre os anos 80 e a primeira década de 2000, Bushwick era território de imigrantes italianos e latinos, gangues e traficantes. Era muito industrial e cinza. Mas artistas, locais e internacionais, organizados por coletivos deram cor a essa transformação. Eles criaram uma galeria de centenas de murais ao ar livre que vivem em constante mudança e que não para de crescer.",
                            Titulo = "Artistas usam ruas como galerias em bairro de Nova York"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities.Noticia", b =>
                {
                    b.HasOne("Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities.Categoria", "Categoria")
                        .WithMany("Noticias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities.Categoria", b =>
                {
                    b.Navigation("Noticias");
                });
#pragma warning restore 612, 618
        }
    }
}
