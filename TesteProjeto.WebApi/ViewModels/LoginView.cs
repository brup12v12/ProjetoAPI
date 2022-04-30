using System.ComponentModel.DataAnnotations;

namespace ProjetoTeste.WebApi.ViewModels
{
    public class LoginView
    {
            [Required(ErrorMessage = "Informe o email do usuário")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Informe a senha do usuário")]
            public string Senha { get; set; }
    }
}
