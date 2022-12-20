using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities;

namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<int> Delete(Categoria categoria);
        Task<Categoria> FindById(int id);
        Task<IEnumerable<Categoria>> GetAllCategorias();
        Task<int> Save(Categoria categoria);
    }
}
