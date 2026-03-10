using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Application.UseCase;

namespace Sehlea.Api.Controllers
{
    [Route("api/estudios")]
    [ApiController]
    public class EstudiosMedicosController : ControllerBase
    {
        private readonly AgregarEstudioMedico _agregarEstudioMedico;
        private readonly ConsultarEstudioMedico _consultarEstudioMedico;

        public EstudiosMedicosController(AgregarEstudioMedico agregarEstudioMedico,
            ConsultarEstudioMedico consultarEstudioMedico)
        {
            _agregarEstudioMedico = agregarEstudioMedico;
            _consultarEstudioMedico = consultarEstudioMedico;
        }


        [HttpPost("add")]
        public async Task<ActionResult> AgregarEstudioMedico(EstudioMedicoDTO estudioMedicoDTO)
        {
            var res = await _agregarEstudioMedico.AgregarEstudioMedicoTask(estudioMedicoDTO);
            if (!res.status)
            {
                return BadRequest(res.message);
            }
            return Ok(res.message);
        }


        [HttpGet("{cedula}")]
        public async Task<ActionResult> ConsultarEstudioMedico(string cedula)
        {
            var res = await _consultarEstudioMedico.ConsultarEstudioMedicoTask(cedula);
            return Ok(res);
        }

    }
}
