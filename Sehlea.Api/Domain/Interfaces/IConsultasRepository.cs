using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IConsultasRepository
    {
        Task AgregarConsultaAsync(Consulta consulta);
        Task<bool> GuardarConsultaAsync(); //si el resultado es exitoso, devuelve true sin exponer lo que se guardó
        Task<Consulta?> BuscarConsultaAsync(int id);
    }
}
