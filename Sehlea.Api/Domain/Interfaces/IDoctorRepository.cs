using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IDoctorRepository
    {
        Task AgregarDoctorAsync(Consulta consulta);
        Task<bool> GuardarDoctorAsync();
        Task<Doctor?> BuscarDoctorAsync(string dni);
    }
}
