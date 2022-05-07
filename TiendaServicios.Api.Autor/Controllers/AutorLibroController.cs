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
        [HttpPut]
        public async Task<bool> EditarRegistro(AutorLibro autor)
        {
            _context.Update(autor);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpPost]
        public async Task<bool> AgregarNuevoRegistro(AutorLibro autor)
        {
            _context.Add(autor);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpDelete]
        public async Task<IActionResult> BorrarNuevoRegistro(int IdAutorLibro)
        {
            var registro = _context.AutoresLibros.FirstOrDefault(x => x.IdAutorLibro == IdAutorLibro);
            if (registro == null)
                return NotFound();
            return Ok();
        }

    }
}
