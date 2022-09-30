using System.ComponentModel.DataAnnotations;

namespace PRJ_Delivery_Blazor.DTOs
{
    public class LocalidadInsertarDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        
        public int IdLocalidad { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Calle { get; set; } = null!;

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Barrio { get; set; } = null!;

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string Zona { get; set; } = null!;
    }
    public class LocalidadActualizarDTO : LocalidadInsertarDTO
    {
        [Required]
        public bool Estado { get; set; }


    }
}

