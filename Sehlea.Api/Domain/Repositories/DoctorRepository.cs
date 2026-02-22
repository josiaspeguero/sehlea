using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Domain.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public Task AgregarDoctorAsync(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task<Doctor?> BuscarDoctorAsync(string dni)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GuardarDoctorAsync()
        {
            throw new NotImplementedException();
        }
    }
}
