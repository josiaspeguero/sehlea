using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Application.UseCase;

namespace Sehlea.Api.Controllers
{
    [Route("api/consultas")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private readonly AgregarConsulta _agregarConsulta;
        private readonly BuscarConsulta _buscarConsulta;

        public ConsultasController(AgregarConsulta agregarConsulta, BuscarConsulta buscarConsulta)
        {
            _agregarConsulta = agregarConsulta;
            _buscarConsulta = buscarConsulta;
        }

        [HttpPost("create")]
        public async Task<ActionResult> CrearConsulta(ConsultaDTO consultaDTO)
        {
            var res = await _agregarConsulta.AgregarConsultaTask(consultaDTO);
            if (!res.status)
            {
                return BadRequest(res.message);
            }
            return Ok(res.message);
        }

        [HttpGet("detail/{id}")]
        public async Task<ActionResult> BuscarConsulta(int id)
        {
            var res = await _buscarConsulta.BuscarConsultaTask(id);
            return Ok(res);
        }
    }
}
