using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class AgregarResultado
    {
        private readonly IResultadoEstudioRepository _resultadoEstudio;
        private readonly IMapper _mapper;

        public AgregarResultado(IResultadoEstudioRepository resultadoEstudio, IMapper mapper)
        {
            _resultadoEstudio = resultadoEstudio;
            _mapper = mapper;
        }
        public async Task<(bool status, string message)> AgregarResultadoTask(ResultadoEstudioDTO resultadoEstudioDTO)
        {
            var nuevoResultado = _mapper.Map<ResultadoEstudio>(resultadoEstudioDTO);
            await _resultadoEstudio.AgregarResultadoEstudioAsync(nuevoResultado);
            var resultadoEstudioGuardado = await _resultadoEstudio.GuardarResultadoEstudioAsync();

            if (!resultadoEstudioGuardado)
            {
                return (false, "No se pudo guardar el resultado");
            }
            return (true, "Resultado agregado");
        }
    }
}
