using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThomasGreg.WebApp.ViewsModel
{
    public class CustomerViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Informe Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; }
    }
}
