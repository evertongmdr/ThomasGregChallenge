using System.ComponentModel.DataAnnotations;
using ThomasGreg.WebApp.Extensions;

namespace ThomasGreg.WebApp.ViewsModel
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Informe o sobre nome")]
        [Display(Name = "Sobre Nome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [PasswordValidationAttribute]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
