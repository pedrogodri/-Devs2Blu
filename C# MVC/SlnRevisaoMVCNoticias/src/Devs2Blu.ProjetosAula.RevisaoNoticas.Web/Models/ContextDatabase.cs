using Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Noticia>()
                .HasOne(f => f.Categoria)
                .WithMany(c => c.Noticias)
                .HasForeignKey(f => f.CategoriaId);

            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Análise" },
                new { Id = 2, Nome = "Artigo" },
                new { Id = 3, Nome = "Humor" },
                new { Id = 4, Nome = "Crônicas" }
                );

            modelBuilder.Entity<Noticia>()
                .HasData(
                new { Id = 1, 
                      Titulo = "Políticas de D&I são adotadas por 58% dos departamentos jurídico, financeiro e de compliance", 
                      Descricao = "Segundo o último levantamento realizado pela equipe da Análise Editorial para produção do " +
                                "anuário ANÁLISE EXECUTIVOS JURÍDICOS E FINANCEIROS 2022 - edição especial de 15 anos - cer" +
                                "ca de seis em cada dez departamentos - sendo eles jurídico, financeiro e de compliance - t" +
                                "rabalham com políticas em prol da diversidade. Dentre os executivos que participaram da pe" +
                                "squisa, 30% preferiram não responder à questão.\r\n\r\nAs palestras e treinamentos para pr" +
                                "omoção de um ambiente empresarial mais inclusivo se destacam nos setores jurídico (83%), f" +
                                "inanceiro (84%) e de compliance (97%). Seguindo a mesma linha, o estímulo à criação de gru" +
                                "pos temáticos e acessibilidade também ganham uma colocação alta com um média total de 70% " +
                                "e 59% para cada prática, respectivamente.", 
                      CategoriaId = 1 
                    },
                new { Id = 2, Titulo = "A reinvenção do cotidiano em tempos de pandemia", 
                      Descricao = "Em 2020, o Estatuto da Criança e do Adolescente (ECA) faz 30 anos. Esse marco coincide c" +
                      "om a pandemia causada pela COVID-19, que coloca em conflito noções de direito ligadas à preservação " +
                      "da vida e da liberdade apresentadas pelo próprio ECA. Diante desse contexto, este artigo trata a res" +
                      "peito de reinvenções e deslocamentos diante da quarentena, os quais se pautam pelo direito à vida ao" +
                      " mesmo tempo em que restringem o direito à liberdade. Ao assumir a inseparabilidade que Michel de Ce" +
                      "rteau postula quanto às noções de estratégia e tática, o artigo explora, metodologicamente, seis cen" +
                      "as expressivas da reinvenção do cotidiano – e que estão vinculadas, cada uma a seu modo, a três dime" +
                      "nsões específicas: a relação de famílias com as tecnologias; a relação das famílias com a escola; e " +
                      "a relação das famílias com suas crianças. As quatro cenas iniciais, exploradas a partir da configura" +
                      "ção de estratégia, indicam esforços para a conformação das formas de organização do social. Neste ca" +
                      "so, fica evidente como, de um lado, a relação das famílias com as tecnologias, e, de outro, a relaçã" +
                      "o das famílias com a escola sugerem práticas comprometidas com a manutenção de formas de existir, me" +
                      "smo em meio a um contexto de excepcionalidade. As duas últimas cenas, situadas a partir da configura" +
                      "ção de tática, dão visibilidade às práticas cotidianas das famílias com suas crianças, ou seja, ao q" +
                      "ue entendemos serem relatos de pessoas ordinárias e que, justamente por meio dessa condição, apontam" +
                      " possibilidades de criação do novo.", 
                      CategoriaId = 2 
                    },
                new { Id = 3, 
                      Titulo = "A ciência e o humor: pesquisas estudam os benefícios do riso para a saúde", 
                      Descricao = "Há um diálogo memorável em “O Nome da Rosa”, do escritor e intelectual italiano Umberto " +
                      "Eco (1932-2016), sobre a comédia e o riso. O personagem principal, Guilherme de Baskerville, entra e" +
                      "m uma discussão com o monge Jorge de Burgos, um forte crítico não só da comédia, mas do riso em si, " +
                      "desde as de natureza intelectual – “O riso é incentivo à dúvida” – como as de natureza estética mesm" +
                      "o – “O riso sacode o corpo, deforma os traços fisionômicos”. A defesa de Guilherme, por sua vez, é m" +
                      "ais intelectual – “O riso é próprio do homem, é sinal de sua racionalidade”. Mas é possível fazer ta" +
                      "mbém uma defesa científica do riso.\r\n\r\nUm estudo de 2020, conduzido por pesquisadores de univers" +
                      "idades de Alemanha, Suíça e EUA, concluiu o que a nós pode parecer intuitivamente claro: o bom humor" +
                      " faz bem tanto para a vida pessoal como no ambiente de trabalho. O estudo envolveu pouco mais de 530" +
                      " pessoas, e a ideia era fazer com que, por uma semana, o grupo, dividido em 4 subgrupos, se dedicass" +
                      "e a: fazer três coisas divertidas por dia; inovar no uso de alguma brincadeira; e enumerasse episódi" +
                      "os divertidos do cotidiano (o quarto grupo foi o de controle). Três meses de acompanhamento depois, " +
                      "o estudo mostrou que o espírito do brincar acabou se incorporando à rotina.",  
                      CategoriaId = 3 
                    },
                new { Id = 4, 
                      Titulo = "Artistas usam ruas como galerias em bairro de Nova York", 
                      Descricao = "Não é a Nova York das compras e do luxo que milhões de turistas buscam todos os anos. Ma" +
                      "s esta Nova York, a oito quilômetros da agitada ilha de Manhattan, o coração da cidade, também vale " +
                      "uma visita. Bushwick é um bairro que literalmente redesenhou sua história.\r\n\r\nEntre os anos 80 e" +
                      " a primeira década de 2000, Bushwick era território de imigrantes italianos e latinos, gangues e tra" +
                      "ficantes. Era muito industrial e cinza. Mas artistas, locais e internacionais, organizados por colet" +
                      "ivos deram cor a essa transformação. Eles criaram uma galeria de centenas de murais ao ar livre que " +
                      "vivem em constante mudança e que não para de crescer.", 
                      CategoriaId = 4 
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
        #region
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Noticia> Noticia { get; set; }
        #endregion
    }
}
