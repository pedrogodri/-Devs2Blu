using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Repository;
using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Services.Interfaces;

namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Services.Implements
{
    public class CategoriaService : ICategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService(CategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(Categoria categoria)
        {
            return await _repository.DeleteCategoria(categoria);
        }

        public async Task<Categoria> FindById(int id)
        {
            return await _repository.FindByIdCategoria(id);
        }

        public async Task<IEnumerable<Categoria>> GetAllCategorias()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Categoria categoria)
        {
            return await _repository.SaveCategoria(categoria);
        }
    }
}
