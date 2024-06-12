using LANCHESMVC.Models;

namespace LANCHESMVC.ViewModels;

public class LancheListViewModel
{
    public IEnumerable<Lanche> Lanches { get; set; }    

    public string CategoriaAtual { get; set; }


}
