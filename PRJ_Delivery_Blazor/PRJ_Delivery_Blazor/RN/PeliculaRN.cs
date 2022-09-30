using Peliculas.DTOs;

namespace Peliculas.RN
{
    public class PeliculaRN
    {
        public static async Task<List<PeliculaDTO>> getAll()
        {
            await Task.Delay(3000); // simlando que api tarda 3 segundos en responder
            return new List<PeliculaDTO>() {
                new PeliculaDTO{ Id=1, Nombre = "<b> Dragon Ball Super:</b> Super hero", FechaEstreno = new DateTime(2022,9,1)},
                new PeliculaDTO{ Id=2, Nombre = "La huerfana: el origen", FechaEstreno = new DateTime(2022,8,1)},
                new PeliculaDTO{ Id=3, Nombre = "Spiderman", FechaEstreno = new DateTime(2022,9,1)},
                new PeliculaDTO{ Id=4, Nombre = "Superman", FechaEstreno = new DateTime(2022,9,1)},
                new PeliculaDTO{ Id=5, Nombre = "Dora", FechaEstreno = new DateTime(2022,9,1)},
                new PeliculaDTO{ Id=6, Nombre = "La bala que doblo la esquina", FechaEstreno = new DateTime(2022,9,1)},
                new PeliculaDTO{ Id=7, Nombre = "La muerte chabelo", FechaEstreno = new DateTime(2022,9,1)},
            };
        }
    }
}
