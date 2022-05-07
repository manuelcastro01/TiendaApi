using Microsoft.AspNetCore.Mvc;
using TiendaServicios.Api.Autor.Modelo;
using TiendaServicios.Api.Autor.Persistencia;

namespace TiendaServicios.Api.Autor.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AutorLibroController : ControllerBase
    {
        private readonly ContextoAutor _context;
        public AutorLibroController(ContextoAutor contexto)
        {
            _context = contexto;
        }
        [HttpPost]
        public bool AgregarNuevoRegistro(AutorLibro autor)
        {
            _context.Add(autor);
            _context.SaveChanges();
            return true;
        }
        [HttpDelete]
        public bool BorrarNuevoRegistro(int IdAutorLibro)
        {
            return true;
        }

    }
}
