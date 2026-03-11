using Microsoft.AspNetCore.Mvc;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Application.UseCase;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Controllers
{
    [ApiController]
    [Route("api/pacientes")]
    public class PacientesController : ControllerBase
    {
        private readonly AgregarPaciente _agregarPaciente;
        private readonly MostrarPacientes _mostrarPacientes;

        public PacientesController(AgregarPaciente agregarPaciente, MostrarPacientes mostrarPacientes)
        {
            _agregarPaciente = agregarPaciente;
            _mostrarPacientes = mostrarPacientes;
        }

        [HttpPost("create")]
        public async Task<ActionResult> AgregarPaciente(PacienteDTO pacienteDTO)
        {
            var res = await _agregarPaciente.AgregarPacienteTask(pacienteDTO);
            if (!res.status)
            {
                return NotFound(res.message);
            }
            return Ok(res.message);
        }

        [HttpGet("view")]
        public async Task<ActionResult> MostrarPacientes()
        {
            try
            {
                var res = await _mostrarPacientes.MostrarPacientesTask();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message, stackTrace = ex.StackTrace });
            }
        }
    }
}
