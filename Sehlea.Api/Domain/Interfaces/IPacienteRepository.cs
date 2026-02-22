using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        Task AgregarPacienteAsync(Consulta consulta);
        Task<bool> GuardarPacienteAsync(); 
        Task<Paciente?> BuscarPacienteAsync(string dni);
    }
}
