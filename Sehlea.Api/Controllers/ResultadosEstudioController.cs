using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Application.UseCase;

namespace Sehlea.Api.Controllers
{
    [Route("api/resultados")]
    [ApiController]
    public class ResultadosEstudioController : ControllerBase
    {
        private readonly AgregarResultado _agregarResultado;
        private readonly ObtenerResultadosPorEstudio _obtenerResultadosPorEstudio;

        public ResultadosEstudioController(AgregarResultado agregarResultado, ObtenerResultadosPorEstudio obtenerResultadosPorEstudio)
        {
            _agregarResultado = agregarResultado;
            _obtenerResultadosPorEstudio = obtenerResultadosPorEstudio;
        }

        [HttpGet("estudio/{estudioId}")]
        public async Task<ActionResult<List<ResultadoEstudioDTO>>> ObtenerResultadosPorEstudio(int estudioId)
        {
            var resultados = await _obtenerResultadosPorEstudio.Execute(estudioId);
            return Ok(resultados);
        }

        [HttpPost]
        public async Task<ActionResult> AgregarResultado(ResultadoEstudioDTO resultadoEstudioDTO)
        {
            var res = await _agregarResultado.AgregarResultadoTask(resultadoEstudioDTO);
            if (!res.status)
            {
                return BadRequest(res.message);
            }
            return Ok(res.message);
        }
    }
}
