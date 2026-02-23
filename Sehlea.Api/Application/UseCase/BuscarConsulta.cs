using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class BuscarConsulta
    {
        private readonly IConsultasRepository _consultas;

        public BuscarConsulta(IConsultasRepository consultas)
        {
            _consultas = consultas;
        }


        public async Task<ConsultaDTO?> BuscarConsultaTask(int id)
        {
            var res = await _consultas.BuscarConsultaAsync(id);
            return (res);
        }
    }
}
