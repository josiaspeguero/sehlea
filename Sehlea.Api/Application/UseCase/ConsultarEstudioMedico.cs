using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class ConsultarEstudioMedico
    {
        private readonly IEstudioMedicoRepository _estudioMedico;

        public ConsultarEstudioMedico(IEstudioMedicoRepository estudioMedico)
        {
            _estudioMedico = estudioMedico;
        }
        public async Task<EstudioMedico?> ConsultarEstudioMedicoTask(string cedula)
        {
            return await _estudioMedico.BuscarEstudioMedicoAsync(cedula);
        }
    }
}
