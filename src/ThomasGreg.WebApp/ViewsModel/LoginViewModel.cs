using System.ComponentModel.DataAnnotations;
using ThomasGreg.WebApp.Extensions;

namespace ThomasGreg.WebApp.ViewsModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
