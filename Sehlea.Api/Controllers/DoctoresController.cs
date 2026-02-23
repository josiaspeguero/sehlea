using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Application.UseCase;

namespace Sehlea.Api.Controllers
{
    [Route("api/doctores")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        private readonly AgregarDoctor _agregarDoctor;
        private readonly MostrarDoctores _mostrarDoctores;

        public DoctoresController(AgregarDoctor agregarDoctor, MostrarDoctores mostrarDoctores)
        {
            _agregarDoctor = agregarDoctor;
            _mostrarDoctores = mostrarDoctores;
        }
        [HttpPost("create")]
        public async Task<ActionResult> AgregarDoctor(DoctorDTO doctorDTO)
        {
            var res = await _agregarDoctor.AgregarDoctorTask(doctorDTO);
            if (!res.status)
            {
                NotFound(res.message);
            }
            return Ok(res.message);
        }

        [HttpGet("view")]
        public async Task<ActionResult> MostrarDoctores()
        {
            var res = await _mostrarDoctores.MostrarDoctoresTask();
            return Ok(res);
        }
    }
}
