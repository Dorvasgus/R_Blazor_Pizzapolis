using System.ComponentModel.DataAnnotations;

namespace PRJ_Delivery_Blazor.DTOs
{
    public class ClienteInsertarDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Nit { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string RazonSocial { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Localidad { get; set; } = null!;
    }
    public class ClienteActualizarDTO : ClienteInsertarDTO
    {
        [Required]
        public bool Estado { get; set; }


    }
}
