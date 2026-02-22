using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Domain.Repositories
{
    public class EstudioMedicosRepository : IEstudioMedicoRepository
    {
        public Task AgregarEstudioMedicoAsync(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task<EstudioMedico?> BuscarEstudioMedicoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarEstudioMedicoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
