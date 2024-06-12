using LANCHESMVC.Context;
using LANCHESMVC.Models;
using LANCHESMVC.Repositories.Interfaces;

namespace LANCHESMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}