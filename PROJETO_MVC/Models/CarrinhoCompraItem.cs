using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LANCHESMVC.Models;

[Table("CarrinhoCompraItens")]
public class CarrinhoCompraItem
{

    public int CarrinhoCompraItemId { get; set; }
    public Lanche Lanche { get; set; }

    public int Quantidade { get; set; }

    [StringLength(300)]
    public string CarrinhoCompraId { get; set; }

}
