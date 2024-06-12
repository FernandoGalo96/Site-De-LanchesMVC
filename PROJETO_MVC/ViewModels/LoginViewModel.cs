using System.ComponentModel.DataAnnotations;

namespace LANCHESMVC.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage ="Usuário obrigatório")]
    [Display(Name ="Usuário")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Senha obrigatória")]
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]

    public string Password { get; set; }

    public string ReturnUrl { get; set; }
}
