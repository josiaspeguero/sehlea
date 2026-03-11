using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Application.UseCase;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Controllers
{
    [Route("api/consultas")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private readonly AgregarConsulta _agregarConsulta;
        private readonly BuscarConsulta _buscarConsulta;
        private readonly ObtenerProximasConsultas _obtenerProximasConsultas;

        public ConsultasController(AgregarConsulta agregarConsulta, BuscarConsulta buscarConsulta, ObtenerProximasConsultas obtenerProximasConsultas)
        {
            _agregarConsulta = agregarConsulta;
            _buscarConsulta = buscarConsulta;
            _obtenerProximasConsultas = obtenerProximasConsultas;
        }

        [HttpGet("upcoming")]
        public async Task<ActionResult<List<Consulta>>> ObtenerProximasConsultas()
        {
            var res = await _obtenerProximasConsultas.Execute();
            return Ok(res);
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
