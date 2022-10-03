namespace PRJ_Delivery_Blazor.DTOs
{
    public class FuncionarioDTO
    {
        public int IdFuncionario { get; set; }
        public string Correo { get; set; } = null!;
        public int IdUsuario { get; set; }
        public int? Vehiculo { get; set; }
        public int IdRol { get; set; }
    }
}
