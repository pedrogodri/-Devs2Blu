using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models;
using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Repository
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
    }
}
