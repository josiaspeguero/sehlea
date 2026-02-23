using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.Interfaces
{
    public interface IResultadoEstudioRepository
    {
        Task AgregarResultadoEstudioAsync(ResultadoEstudio resultadoEstudio);
        Task<bool> GuardarResultadoEstudioAsync(); //si el resultado es exitoso, devuelve true sin exponer lo que se guardó
        Task<ResultadoEstudio?> BuscarResultadoEstudioAsync(int id);
    }
}
