using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class ObtenerResultadosPorEstudio
    {
        private readonly IResultadoEstudioRepository _resultadoEstudioRepository;
        private readonly IMapper _mapper;

        public ObtenerResultadosPorEstudio(IResultadoEstudioRepository resultadoEstudioRepository, IMapper mapper)
        {
            _resultadoEstudioRepository = resultadoEstudioRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultadoEstudioDTO>> Execute(int estudioId)
        {
            var resultados = await _resultadoEstudioRepository.ObtenerResultadosPorEstudioIdAsync(estudioId);
            return _mapper.Map<List<ResultadoEstudioDTO>>(resultados);
        }
    }
}
