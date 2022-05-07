using System.ComponentModel.DataAnnotations;

namespace TiendaServicios.Api.Autor.Modelo
{
    public class GradoAcademico
    {
        [Key]
        public int IdGradoAcademico { get; set; }
        //public AutorLibro AutorLibro { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaGrado { get; set; }
        public string CentroAcademico { get; set; }
    }
}
