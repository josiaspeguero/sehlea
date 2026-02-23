using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IDoctorRepository
    {
        Task AgregarDoctorAsync(Doctor doctor);
        Task<bool> GuardarDoctorAsync();
        Task<Doctor?> BuscarDoctorAsync(string dni);
        Task<IEnumerable<Doctor>> MostrarDoctoresAsync();
    }
}
