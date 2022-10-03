﻿namespace PRJ_Delivery_Blazor.DTOs
{
    public class ResponseListDTO<T>
    {
        public int pagina { get; set; }
        public int total { get; set; }
        public int cantidad { get; set; }
        public List<T> valores { get; set; } = new List<T>();
    }
}
