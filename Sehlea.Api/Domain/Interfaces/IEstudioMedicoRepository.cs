using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IEstudioMedicoRepository
    {
        Task AgregarEstudioMedicoAsync(EstudioMedico estudioMedico);
        Task<bool> GuardarEstudioMedicoAsync();
        Task<EstudioMedico?> BuscarEstudioMedicoAsync(string cedula); //se buscara por cedula del paciente
        Task<EstudioMedico?> BuscarEstudioPorIdAsync(int id);
        Task<IEnumerable<EstudioMedico>> GetAllEstudiosAsync();
    }
}
