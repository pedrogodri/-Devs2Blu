using Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities;
using Devs2Blu.ProjetoAula.Exercicio.Web.Repository;
using Devs2Blu.ProjetoAula.Exercicio.Web.Services.Interfaces;

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Services.Implements
{
    public class CategoriaService : ICategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService(CategoriaRepository repository)
        {
            _repository = repository;
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
