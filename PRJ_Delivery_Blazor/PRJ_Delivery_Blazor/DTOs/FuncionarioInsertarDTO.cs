using System.ComponentModel.DataAnnotations;

namespace PRJ_Delivery_Blazor.DTOs
{
    public class FuncionarioInsertarDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public int IdFuncionario { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "El campo Correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "No tiene formato de correo ejem. correo@dominio.com")]
        [StringLength(100)]
        public string Correo { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Rol { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        
        public int Vehiculo { get; set; }
    }
    public class FuncionarioActualizarDTO : FuncionarioInsertarDTO
    {
        [Required]
        public bool Estado { get; set; }


    }
}
