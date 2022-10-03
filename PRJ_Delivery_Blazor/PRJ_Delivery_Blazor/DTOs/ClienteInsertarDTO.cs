using System.ComponentModel.DataAnnotations;

namespace PRJ_Delivery_Blazor.DTOs
{
    public class ClienteInsertarDTO
    {

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public int idCliente { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Nit { get; set; } = null!;
    }
}
