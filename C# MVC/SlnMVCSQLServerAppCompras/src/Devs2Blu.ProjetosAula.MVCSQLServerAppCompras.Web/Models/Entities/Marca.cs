namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
