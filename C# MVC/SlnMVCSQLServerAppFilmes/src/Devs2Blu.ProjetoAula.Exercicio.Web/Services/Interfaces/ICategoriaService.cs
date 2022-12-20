using Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities;

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAllCategorias();
        Task<int> Save(Categoria categoria);
    }
}
