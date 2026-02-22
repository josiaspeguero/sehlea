using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Domain.Repositories
{
    public class ConsultaRepository : IConsultasRepository
    {
        public Task AgregarConsultaAsync(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task<Consulta?> BuscarConsultaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarConsultaAsync()
        {
            throw new NotImplementedException();
        }
    }
}
