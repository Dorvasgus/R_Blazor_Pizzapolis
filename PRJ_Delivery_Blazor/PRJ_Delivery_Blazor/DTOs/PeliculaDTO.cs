namespace Peliculas.DTOs
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaEstreno  { get; set; }
    }
}
