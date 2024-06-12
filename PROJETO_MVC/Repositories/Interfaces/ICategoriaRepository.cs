using LANCHESMVC.Models;

namespace LANCHESMVC.Repositories.Interfaces;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}