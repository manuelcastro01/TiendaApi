﻿using System.ComponentModel.DataAnnotations;

namespace TiendaServicios.Api.Autor.Modelo
{
    public class AutorLibro
    {
        [Key]
        public int IdAutorLibro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //public ICollection<GradoAcademico> GradosAcademicos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
    }
}
