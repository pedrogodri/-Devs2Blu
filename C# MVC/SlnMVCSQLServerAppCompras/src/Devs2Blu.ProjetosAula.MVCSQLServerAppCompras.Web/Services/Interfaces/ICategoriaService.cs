using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities;

namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAllCategorias();

        Task<int> Save(Categoria categoria);
    }
}
