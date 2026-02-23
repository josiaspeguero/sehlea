using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class MostrarPacientes
    {
        private readonly IPacienteRepository _paciente;

        public MostrarPacientes(IPacienteRepository paciente)
        {
            _paciente = paciente;
        }
        public async Task<IEnumerable<PacienteDTO?>> MostrarPacientesTask()
        {
            return await _paciente.MostrarPacientesAsync();
        }
    }
}
