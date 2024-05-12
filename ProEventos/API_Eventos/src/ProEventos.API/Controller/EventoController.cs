using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       [HttpGet]
        public IActionResult Error()
        {
            return Ok("value");
        }
    }
}