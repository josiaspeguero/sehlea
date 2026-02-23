using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        Task AgregarPacienteAsync(Paciente paciente);
        Task<bool> GuardarPacienteAsync(); 
        Task<Paciente?> BuscarPacienteAsync(string dni);
    }
}
