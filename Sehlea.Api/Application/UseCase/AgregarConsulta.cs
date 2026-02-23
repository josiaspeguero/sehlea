using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class AgregarConsulta
    {
        private readonly IConsultasRepository _consultas;
        private readonly IMapper _mapper;

        public AgregarConsulta(IConsultasRepository consultas, IMapper mapper)
        {
            _consultas = consultas;
            _mapper = mapper;
        }
        public async Task<(bool status, string message)>AgregarConsultaTask(ConsultaDTO consultaDTO)
        {
            var nuevaConsulta =  _mapper.Map<Consulta>(consultaDTO);
            await _consultas.AgregarConsultaAsync(nuevaConsulta);

            var consultaGuardada = await _consultas.GuardarConsultaAsync();
            if (!consultaGuardada) return (false, "No se pudo guardar la consulta");

            //se debe agregar un metodo que envie un correo al paciente
            return (true, "Consulta agregada");
        }
    }
}
