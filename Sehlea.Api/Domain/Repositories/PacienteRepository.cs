using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Domain.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public Task AgregarPacienteAsync(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Task<Paciente?> BuscarPacienteAsync(string dni)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarPacienteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
