using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class MostrarDoctores
    {
        private readonly IDoctorRepository _doctor;

        public MostrarDoctores(IDoctorRepository doctor)
        {
            _doctor = doctor;
        }
        public async Task<IEnumerable<Doctor?>> MostrarDoctoresTask()
        {
            return await _doctor.MostrarDoctoresAsync();
        }
    }
}
