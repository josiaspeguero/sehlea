using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Domain.Repositories
{
    public class ResultadoEstudioRepository : IResultadoEstudioRepository
    {
        public Task AgregarResultadoEstudioAsync(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task<ResultadoEstudio?> BuscarResultadoEstudioAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarResultadoEstudioAsync()
        {
            throw new NotImplementedException();
        }
    }
}
