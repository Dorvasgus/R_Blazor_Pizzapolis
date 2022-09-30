using System.ComponentModel.DataAnnotations;

namespace PRJ_Delivery_Blazor.DTOs
{
    public class ProductosInsertarDTO
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string PizzaFamiliar { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string PizzaMediana { get; set; } = null!;
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(50)]
        public string PizzaPequeña { get; set; } = null!;

    }
    public class ProductoActualizarDTO : ProductosInsertarDTO
    {
        [Required]
        public bool Estado { get; set; }


    }
}
