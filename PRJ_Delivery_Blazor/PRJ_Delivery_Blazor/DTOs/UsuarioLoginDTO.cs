using System.ComponentModel.DataAnnotations;

namespace PRJ_Delivery_Blazor.DTOs
{
    public class UsuarioLoginDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Password { get; set; } = string.Empty;
    }
}
