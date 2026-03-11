using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class ObtenerProximasConsultas
    {
        private readonly IConsultasRepository _consultasRepository;

        public ObtenerProximasConsultas(IConsultasRepository consultasRepository)
        {
            _consultasRepository = consultasRepository;
        }

        public async Task<List<Consulta>> Execute()
        {
            return await _consultasRepository.ObtenerProximasConsultasAsync();
        }
    }
}
