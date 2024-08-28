using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NumeroController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroController : ControllerBase
    {
        private readonly ILogger<NumeroController> _logger;

        public NumeroController(ILogger<NumeroController> logger)
        {
            _logger = logger;
        }

        // Método POST que recibe un número y devuelve el número incrementado en 1
        [HttpPost]
        [Route("Incrementar")]
        public IActionResult Incrementar([FromBody] int? numero)
        {
            try
            {
                // Validar si el número es nulo
                if (numero == null)
                {
                    _logger.LogWarning("Solicitud inválida: el número no puede ser nulo o no es un entero válido.");
                    return BadRequest("El valor proporcionado no es válido. Asegúrese de enviar un número entero.");
                }

                int resultado = numero.Value + 1;

                // Devolver el resultado con un código de respuesta 200 OK
                return Ok(new { Resultado = resultado });
            }
            catch (Exception ex)
            {
                // Registrar el error en el log
                _logger.LogError(ex, "Error al incrementar el número.");

                // Devolver una respuesta 500 Internal Server Error con un mensaje genérico
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocurrió un error al procesar su solicitud.");
            }
        }
    }
}
