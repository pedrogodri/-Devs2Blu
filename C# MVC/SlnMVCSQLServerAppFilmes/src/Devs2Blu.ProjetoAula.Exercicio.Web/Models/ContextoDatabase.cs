using Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Filme>()
                .HasOne(f => f.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey(f => f.CategoriaId);

            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Terror" },
                new { Id = 2, Nome = "Ação e aventura" },
                new { Id = 3, Nome = "Comédia" },
                new { Id = 4, Nome = "Drama" }
                );

            modelBuilder.Entity<Filme>()
                .HasData(
                new { Id = 1, Nome = "Telefone preto", Lancamento = "21 de julho de 2022", Classificacao = "16 anos", CategoriaId = 1 },
                new { Id = 2, Nome = "It - A Coisa", Lancamento = "7 de setembro de 2017", Classificacao = "16 anos", CategoriaId = 1 },
                new { Id = 3, Nome = "Vingadores: Ultimato", Lancamento = "25 de abril de 2019", Classificacao = "12 anos", CategoriaId = 2 },
                new { Id = 4, Nome = "Homem-Aranha: De Volta ao Lar", Lancamento = "6 de julho de 2017", Classificacao = "12 anos", CategoriaId = 2 },
                new { Id = 5, Nome = "Ted", Lancamento = "21 de setembro de 2012", Classificacao = "16 anos", CategoriaId = 3 },
                new { Id = 6, Nome = "Gente Grande 2", Lancamento = "16 de agosto de 2013", Classificacao = "12 anos", CategoriaId = 3 },
                new { Id = 7, Nome = "A Culpa É das Estrelas", Lancamento = "5 de junho de 2014", Classificacao = "12 anos", CategoriaId = 4 },
                new { Id = 8, Nome = "Por Lugares Incríveis", Lancamento = "28 de fevereiro de 2020", Classificacao = "16 anos", CategoriaId = 4 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSet
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Filme> Filme { get; set; }
        #endregion
    }
}
