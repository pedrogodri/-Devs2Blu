using Devs2Blu.ProjetoAula.Exercicio.Web.Models;
using Devs2Blu.ProjetoAula.Exercicio.Web.Models.Entities;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoAula.Exercicio.Web.Repository
{
    public class CategoriaRepository
    {
        private readonly ContextoDatabase _context;

        public CategoriaRepository(ContextoDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _context.Categoria.ToListAsync();
        }

        public async Task<int> SaveCategoria(Categoria categoria)
        {
            _context.Add(categoria);
            return await _context.SaveChangesAsync();
        }
    }
}
