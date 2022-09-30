namespace PRJ_Delivery_Blazor.DTOs
{
    public class ResponseListDTO<T>
    {
        public int pagina { get; set; }
        public int totalRegistros { get; set; }
        public int cantidadPaginas { get; set; }
        public List<T> valores { get; set; } = new List<T>();
    }
}
