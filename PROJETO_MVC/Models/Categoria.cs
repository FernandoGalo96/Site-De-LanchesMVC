using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LANCHESMVC.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "Informe o nome da categoria!")]
    [StringLength(100, ErrorMessage = "Tamanho máximo: 100")]
    [Display(Name = "Name")]
    public string CategoriaNome { get; set; }

    [Required(ErrorMessage = "Informe a descrição!")]
    [StringLength(200, ErrorMessage = "Tamanho máximo: 200")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    public List<Lanche> Lanches { get; set; }
}