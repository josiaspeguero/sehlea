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
        private readonly MostrarEstudios _mostrarEstudios;
        private readonly BuscarEstudioPorId _buscarEstudioPorId;

        public EstudiosMedicosController(AgregarEstudioMedico agregarEstudioMedico,
            ConsultarEstudioMedico consultarEstudioMedico,
            MostrarEstudios mostrarEstudios,
            BuscarEstudioPorId buscarEstudioPorId)
        {
            _agregarEstudioMedico = agregarEstudioMedico;
            _consultarEstudioMedico = consultarEstudioMedico;
            _mostrarEstudios = mostrarEstudios;
            _buscarEstudioPorId = buscarEstudioPorId;
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

        [HttpGet("id/{id}")]
        public async Task<ActionResult> BuscarEstudioPorId(int id)
        {
            var res = await _buscarEstudioPorId.ExecuteAsync(id);
            if (res == null) return NotFound();
            return Ok(res);
        }

        [HttpGet("view")]
        public async Task<ActionResult> MostrarEstudios()
        {
            var res = await _mostrarEstudios.ExecuteAsync();
            return Ok(res);
        }
    }
}
