using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NumeroController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroController : ControllerBase
    {
        // Método POST que recibe un número y devuelve el número incrementado en 1
        [HttpPost]
        [Route("Incrementar")]
        public IActionResult Incrementar([FromBody] int numero)
        {
            int resultado = numero + 1;
            return Ok(resultado);
        }
    }
}
