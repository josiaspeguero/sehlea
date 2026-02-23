using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class AgregarPaciente
    {
        private readonly IPacienteRepository _paciente;
        private readonly IMapper _mapper;

        public AgregarPaciente(IPacienteRepository paciente, IMapper mapper)
        {
            _paciente = paciente;
            _mapper = mapper;
        }
        public async Task<(bool status, string message)> AgregarPacienteTask(PacienteDTO pacienteDTO)
        {
            var pacienteExistente = await _paciente.BuscarPacienteAsync(pacienteDTO.Cedula);
            if (pacienteExistente != null) return (false, "Ya existe un paciente con ese DNI");

            var nuevoPaciente = _mapper.Map<Paciente>(pacienteDTO);
            await _paciente.AgregarPacienteAsync(nuevoPaciente);
            var pacienteGuardado = await _paciente.GuardarPacienteAsync();

            if (!pacienteGuardado) return (false, "No se pudo agregar el paciente");
            return (true, "Paciente agregado");
        }
    }
}
