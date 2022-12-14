using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities
{
    [Table("categorias")]
    public class Categoria
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
