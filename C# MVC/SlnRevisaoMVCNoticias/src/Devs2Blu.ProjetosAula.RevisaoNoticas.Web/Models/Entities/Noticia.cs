using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Devs2Blu.ProjetosAula.RevisaoNoticas.Web.Models.Entities
{
    [Table("noticia")]
    public class Noticia
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Column(TypeName = "TEXT")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("categoriaId")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
