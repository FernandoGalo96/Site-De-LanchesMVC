using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LANCHESMVC.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Required]
    [Display(Name = "Nome do Lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "Mínimo 10 caracteres, máximo 80")]
    public string Nome { get; set; }

    [Required]
    [Display(Name = "Descrição do lanche")]
    [StringLength(200, MinimumLength = 20, ErrorMessage = "Mínimo 20 caracteres, máximo 200")]
    public string DescricaoCurta { get; set; }

    [Required]
    [Display(Name = "Descrição detalhada do lanche")]
    [StringLength(200, MinimumLength = 20, ErrorMessage = "Mínimo 10 caracteres, máximo 80")]
    public string DescricaoDetalhada { get; set; }

    [Required]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1, 99.99, ErrorMessage = "Preço = de 1 real até 99,99")]
    public decimal Preco { get; set; }

    [Display(Name = "Caminho da img normal")]
    [StringLength(200)]
    public string ImagemUrl { get; set; }

    [Display(Name = "Caminho da img miniatura")]
    [StringLength(200)]
    public string ImagemThumbNailUrl { get; set; }

    [Display(Name = "Preferido?")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    [Column("CategoriaId")]
    public int CategoriaId { get; set; }

    public virtual Categoria Categoria { get; set; }
}