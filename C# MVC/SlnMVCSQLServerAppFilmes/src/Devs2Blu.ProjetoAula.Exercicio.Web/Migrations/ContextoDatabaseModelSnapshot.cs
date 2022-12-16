﻿// <auto-generated />
using Devs2Blu.ProjetoAula.Exercicio.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Migrations
{
    [DbContext(typeof(ContextoDatabase))]
    partial class ContextoDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities.Categoria", b =>
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

                    b.ToTable("categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Terror"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Ação e aventura"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Comédia"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Drama"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("CategoriaId");

                    b.Property<string>("Classificacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("classificacao");

                    b.Property<string>("Lancamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lancamento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Classificacao = "16 anos",
                            Lancamento = "21 de julho de 2022",
                            Nome = "Telefone preto"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Classificacao = "16 anos",
                            Lancamento = "7 de setembro de 2017",
                            Nome = "It - A Coisa"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            Classificacao = "12 anos",
                            Lancamento = "25 de abril de 2019",
                            Nome = "Vingadores: Ultimato"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Classificacao = "12 anos",
                            Lancamento = "6 de julho de 2017",
                            Nome = "Homem-Aranha: De Volta ao Lar"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 3,
                            Classificacao = "16 anos",
                            Lancamento = "21 de setembro de 2012",
                            Nome = "Ted"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 3,
                            Classificacao = "12 anos",
                            Lancamento = "16 de agosto de 2013",
                            Nome = "Gente Grande 2"
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 4,
                            Classificacao = "12 anos",
                            Lancamento = "5 de junho de 2014",
                            Nome = "A Culpa É das Estrelas"
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 4,
                            Classificacao = "16 anos",
                            Lancamento = "28 de fevereiro de 2020",
                            Nome = "Por Lugares Incríveis"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities.Filme", b =>
                {
                    b.HasOne("Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities.Categoria", "Categoria")
                        .WithMany("Filmes")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities.Categoria", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}