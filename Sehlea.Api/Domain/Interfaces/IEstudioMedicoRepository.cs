using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IEstudioMedicoRepository
    {
        Task AgregarEstudioMedicoAsync(Consulta consulta);
        Task<bool> GuardarEstudioMedicoAsync();
        Task<EstudioMedico?> BuscarEstudioMedicoAsync(int id);
    }
}
