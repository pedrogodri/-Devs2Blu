using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities
{
    [Table("filmes")]
    public class Filme
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("lancamento")]
        [Display(Name = "Lançamento")]
        public string Lancamento { get; set; }

        [Column("classificacao")]
        [Display(Name = "Classificação")]
        public string Classificacao { get; set; }

        [Column("CategoriaId")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }

    }
}
